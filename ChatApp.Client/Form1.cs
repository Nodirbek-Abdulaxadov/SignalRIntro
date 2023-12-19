using ChatApp.Data.Models;
using Microsoft.AspNetCore.SignalR.Client;
using System.Net.Http.Json;

namespace ChatApp.Client;

public partial class Form1 : Form
{
    private readonly HubConnection _connection;
    private readonly string _fullName;
    private string _connectionId;
    private string _currentConnectionId;

    private List<UserConnection> userlar = new();
    public Form1(string fullName)
    {
        InitializeComponent();
        _fullName = fullName;
        _connection = new HubConnectionBuilder()
            .WithUrl("wss://localhost:7299/chatHub")
            .Build();
        label3.Text = _fullName;
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        using var httpClient = new HttpClient();
        var users = await httpClient.GetFromJsonAsync<List<User>>("https://localhost:7299/api/auth/users");
        foreach (var user in users)
        {
            if (user.FullName != _fullName)
            {
                listBox1.Items.Add(user.FullName);
                userlar.Add(new UserConnection()
                {
                    FullName = user.FullName,
                    ConnectionId = null,
                    IsOnline = false
                });
            }
        }

        await _connection.StartAsync();
        _connectionId = _connection.ConnectionId;

        await _connection.InvokeAsync("JoinToChat", _fullName, _connectionId);

        _connection.On<string, string, string>("SomebodyJoined", (fullname, connectionID, message) =>
        {
            Invoke(new Action(() =>
            {
                var user = userlar.FirstOrDefault(x => x.FullName == fullname);
                user.ConnectionId = connectionID;
                user.IsOnline = true;
                richTextBox1.Text += $"{message}\n";
            }));
        });

        _connection.On<string>("ReceiveDM", (message) =>
        {
            Invoke(new Action(() =>
            {
                richTextBox1.Text += $"{message}\n";
            }));
        });

        _connection.On<string, string, string>("SomebodyLeft", (fullname, connectionID, message) =>
        {
            Invoke(new Action(() =>
            {
                var user = userlar.FirstOrDefault(x => x.FullName == fullname);
                user.ConnectionId = null;
                user.IsOnline = false;
                richTextBox1.Text += $"{message}\n";
            }));
        });
    }

    private async void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        var result = MessageBox.Show("Are you sure to leave chat?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.Yes)
        {
            await _connection.InvokeAsync("LeftFromChat", _fullName, _connectionId);
            await _connection.StopAsync();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var message = textBox1.Text;

        _connection.InvokeAsync("SendMessageToUser", _fullName, message, _currentConnectionId);
        textBox1.Clear();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBox1.SelectedItem != null)
        {
            var user = userlar.FirstOrDefault(x => x.FullName == listBox1.SelectedItem.ToString());
            _currentConnectionId = user.ConnectionId;
            label1.Text = user.FullName;
            if (user.IsOnline)
            {
                button1.Enabled = true;
                textBox1.Enabled = true;
                label2.Text = "Online";
            }
            else
            {
                button1.Enabled = false;
                textBox1.Enabled = false;
                label2.Text = "Offline";
            }
            richTextBox1.Text = "";
        }
    }
}

class UserConnection
{
    public string FullName { get; set; }
    public string ConnectionId { get; set; }
    public bool IsOnline { get; set; }
}