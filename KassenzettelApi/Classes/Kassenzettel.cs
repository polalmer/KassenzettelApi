namespace KassenzettelApi.Classes;

public class Kassenzettel
{
    public Kassenzettel() { }

    public Kassenzettel(KassenzettelDto dto)
    {
        Shop = dto.shop;
        Items = new();
        foreach(ItemDto itemDto in dto.items)
        {
            Item item = new(itemDto.amount,itemDto.price,itemDto.name);
            Items.Add(item);
        }
    }

    public int Id { get; set; }

    public List<Item>? Items { get; set; }

    public string? Shop { get; set; }
}
