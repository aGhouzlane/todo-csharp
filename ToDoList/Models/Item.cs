using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {

    public string Description { get; set; }
    private static List<string> _instances = new List<string> { };
    public Item(string description)
    {
      Description = description;
      _instances.Add(description);
    }
    public static List<string> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}