using System.Text.Json.Serialization;

namespace KassenzettelApi.Classes;

public class Item
{
    [JsonIgnore]
    public int Id { get; set; }

    public float Price { get; set; }

    public string Title { get; set; } = string.Empty;
}
