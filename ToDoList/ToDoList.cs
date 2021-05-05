using System;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      PrintMenu();
    }

    public static void PrintMenu()
    {
      string userInput;
      do
      {
        Console.WriteLine("Welcome to the To Do List");
        Console.WriteLine("Would you like to add an item to your list or view your list?");
        Console.WriteLine("Enter 1 to add a item to the list.");
        Console.WriteLine("Enter 2 to view the list.");
        Console.WriteLine("Enter 3 to exit the program.");
        userInput = Console.ReadLine();

        switch (userInput)
        {
          case "1":
            string newItem = Console.ReadLine();
            Item item = new Item(newItem);
            Console.WriteLine("You item was successfully added to the list!");
            break;
          case "2":
            List<string> items = Item.GetAll();
            if (!items.Any())
            {
              Console.WriteLine("The list is empty. Please enter a new item.");
            }
            else
            {
              foreach (var i in items)
              {
                Console.WriteLine(i);
              }
            }
            break;
        }

      } while (userInput != "3");

    }
  }
}