namespace KassenzettelApi.Classes;

public class Item
{
    public int Id { get; set; }

    public int Amount { get; set; }

    public float Price { get; set; }

    public string Name { get; set; } = string.Empty;

    public Kassenzettel Kassenzettel { get; set; }
}
