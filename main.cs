using System;

class Program {
  public static void Main (string[] args) {
     int quantity;
     double price;
     double total;
     string item;


    Console.WriteLine("Enter the name of the item:");
    item = Console.ReadLine(); 
    //user input item

    Console.WriteLine("Enter the quantity:");
    quantity = Convert.ToInt32(Console.ReadLine());
    //user input quantity

    Console.WriteLine("Enter the price:");
    price = Convert.ToDouble(Console.ReadLine());
    //user input price

   total = price * quantity;

    Console.WriteLine("Total price of " + item);
    Console.WriteLine(total);

  }
}