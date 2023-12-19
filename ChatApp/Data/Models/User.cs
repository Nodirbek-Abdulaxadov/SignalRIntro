namespace ChatApp.Data.Models;

public class User
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Password { get; set; } = null!;
}