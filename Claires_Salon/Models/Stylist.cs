using System.Collections.Generic;

namespace Claires_Salon.Models
{
  public class Client
  {
    public Client()
    {
      this.Styleists = new HashSet<Stylist>();
    }

    public int id_client { get; set; }
    public string client_name { get; set; }
    public virtual ICollection<Stylist> Stylists { get; set; }
  }
}