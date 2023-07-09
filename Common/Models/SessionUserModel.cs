namespace Common.Utils.Models;
public class SessionUserModel
{
    public int UserId { get; set; }
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int Role { get; set; }
}