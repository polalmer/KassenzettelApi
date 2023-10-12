namespace KassenzettelApi.Classes;

public class Customer
{
    public int Id { get; set; }
    public string Vorname { get; set; }
    public string Nachname { get; set; }
    public string Nutzername { get; set; }
    public string Passwort { get; set; }
    public List<Kassenzettel> Kassenzettel { get; set; }
}
