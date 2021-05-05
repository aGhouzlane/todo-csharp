using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {

    public string Description { get; set; }
    private static List<Item> _instances = new List<Item> { };
    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // Arrange
      List<Item> newList = new List<Item> { };

      // Act
      List<Item> result = Item.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

  }
}