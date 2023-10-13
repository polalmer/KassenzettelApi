namespace KassenzettelApi.Classes;

public class Item
{
    public Item(int amount, float price, string name)
    {
        Amount = amount;
        Price = price;
        Name = name;
    }

    public int Id { get; set; }

    public int Amount { get; set; }

    public float Price { get; set; }

    public string Name { get; set; } = string.Empty;
}
