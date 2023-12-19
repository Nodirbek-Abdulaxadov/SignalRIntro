using ChatApp.Data.Models;
using System.Net.Http.Json;

namespace ChatApp.Client;
public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        using var httpClient = new HttpClient();
        var response = await httpClient.PostAsJsonAsync("https://localhost:7299/api/auth/login", new LoginUser
        {
            PhoneNumber = textBox2.Text,
            Password = textBox3.Text
        });

        if (response.IsSuccessStatusCode)
        {
            MessageBox.Show("User logged in successfully");
            var user = await response.Content.ReadFromJsonAsync<User>();

            Form1 form1 = new(user.FullName);
            Hide();
            form1.ShowDialog();
            Close();
        }
        else
        {
            MessageBox.Show("User login failed");
        }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Register form1 = new();
        Hide();
        form1.ShowDialog();
        Close();
    }
}
