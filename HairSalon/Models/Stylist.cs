namespace HairSalon.Models
{
  public class Stylist
  {
    public string Name { get; set; }
    public int StylistId { get; set; }
    public List<Client> Clients { get; set; }
  }
}