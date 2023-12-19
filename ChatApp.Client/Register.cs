using ChatApp.Data.Models;
using System.Net.Http.Json;

namespace ChatApp.Client;
public partial class Register : Form
{
    public Register()
    {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        using var httpClient = new HttpClient();
        var response = await httpClient.PostAsJsonAsync("https://localhost:7299/api/auth/register", new RegisterUser
        {
            FullName = textBox1.Text,
            PhoneNumber = textBox2.Text,
            Password = textBox3.Text
        });

        if (response.IsSuccessStatusCode)
        {
            MessageBox.Show("User registered successfully");
            Login form1 = new();
            Hide();
            form1.ShowDialog();
            Close();
        }
        else
        {
            MessageBox.Show("User registration failed");
        }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Login form1 = new();
        Hide();
        form1.ShowDialog();
        Close();
    }
}