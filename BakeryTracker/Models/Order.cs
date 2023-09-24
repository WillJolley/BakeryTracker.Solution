using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public static List<Order> _ordersList = new List<Order> { };

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _ordersList.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _ordersList;
    }
  }
}