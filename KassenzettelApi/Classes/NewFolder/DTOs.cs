using System.ComponentModel.DataAnnotations.Schema;

namespace KassenzettelApi.Classes;


public class ItemDto
{
    public int amount { get; set; }
    public float price { get; set; }
    public string name { get; set; }
}

[NotMapped]
public class KassenzettelDto
{
    public string? shop { get; set; }

    public List<ItemDto> items { get; set; }
}