namespace Claires_Salon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}

// namespace ToDoList.Models
// {
//   public class Item
//   {
//     public int ItemId { get; set; }
//     public string Description { get; set; }
//     public int CategoryId { get; set; }
//     public virtual Category Category { get; set; }
//   }
// }