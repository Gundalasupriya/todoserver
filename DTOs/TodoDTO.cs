using System.Text.Json.Serialization;

namespace TodoTask.DTOs;

public record TodoDTO
{
    [JsonPropertyName("todo_id")]

    public long TodoId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]

    public string Description { get; set; }

    [JsonPropertyName("user_id")]


    public long UserId { get; set; }
}
public record TodoCreateDTO
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }


}

public record TodoUpdateDTO
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }
}