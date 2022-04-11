using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TodoTask.DTOs;

public record UserDTO
{
    [JsonPropertyName("user_id")]

    public long UserId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("password")]

    public string Password { get; set; }

}

public record UserCreateDTO
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("password")]
    public string Password { get; set; }

}




