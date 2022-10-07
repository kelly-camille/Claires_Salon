using System.Collections.Generic;

namespace Claires_Salon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Stylists = new HashSet<Stylist>();
    }

    public int StylistId { get; set; }
    public string StylistName { get; set; }
    public virtual ICollection<Stylist> Stylists { get; set; }
  }
}