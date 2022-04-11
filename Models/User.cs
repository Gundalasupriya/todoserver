using TodoTask.DTOs;

namespace TodoTask.Models;

public record User
{
    public long UserId { get; set; }

    public string Name { get; set; }

    public string Password { get; set; }

    public UserDTO asDTO => new UserDTO
    {
        UserId = UserId,
        Name = Name,
        Password = Password,
    };
}
