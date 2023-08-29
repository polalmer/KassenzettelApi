using System.Text.Json.Serialization;

namespace KassenzettelApi.Classes;

public class Kassenzettel
{
    [JsonIgnore]
    public int Id { get; set; }

    public List<(int count,Item)> Items { get;} = new();

    public string? Shop { get; set; }
}
