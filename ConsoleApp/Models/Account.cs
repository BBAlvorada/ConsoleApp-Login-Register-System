using System.Text;

namespace ConsoleApp.Models;

public class Account
{
    public string? Email { get; set; }
    public string? Password { get; set; }
    public DateTime CreatedAt { get; private set; }

    public UserProfile? UserProfile { get; set; }

    public Account(string email, string password)
    {
        Email = email;
        Password = password;
        CreatedAt = DateTime.Now.Date;
    }

    public override string ToString()
    {
        return new StringBuilder()
            .Append("Account ")
            .Append("{ ")
            .Append($"Email: {Email}, ")
            .Append($"Password: {Password}, ")
            .Append($"CreateAt: {CreatedAt}")
            .AppendLine(" }")
            .Append($"{UserProfile}")
            .ToString();
    }
}