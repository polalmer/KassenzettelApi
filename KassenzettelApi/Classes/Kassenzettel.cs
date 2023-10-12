﻿using System.Text.Json.Serialization;

namespace KassenzettelApi.Classes;

public class Kassenzettel
{
    [JsonIgnore]
    public int Id { get; set; }

    public List<Item>? Items { get; set; }

    public string? Shop { get; set; }
}
