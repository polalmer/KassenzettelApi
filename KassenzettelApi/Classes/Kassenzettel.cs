namespace KassenzettelApi.Classes;

public class Kassenzettel
{
    public int Id { get; set; }

    public int Customer { get; set; }

    public List<Item>? Items { get; set; }

    public string? Shop { get; set; }
}
