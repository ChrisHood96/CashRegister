using System;
using System.Collections.Generic;
namespace Till
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = 0;
            List<Item> basket = new List<Item>();
            List<Item> stock = new List<Item>();
            Item banana = new Item("Banana", 1);
            Item apple = new Item("Apple", 1);
            Item orange = new Item("Orange", 1);
            Item blanket = new Item("Blanket", 2);
            stock.Add(banana);
            stock.Add(apple);
            stock.Add(orange);
            stock.Add(blanket);

            Console.WriteLine("This is what is in stock today: ");
            foreach (Item product in stock)
            {
                Console.WriteLine("Item: " + product.name + ", Price: £" + product.price);
            }

            Console.WriteLine("To stop shopping, type checkout");
            Console.WriteLine("Select Item(s): ");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToUpper() == "CHECKOUT")
                {
                    break;
                }
                foreach (Item product in stock)
                {
                    if (input.ToUpper() == product.name.ToUpper())
                    {
                        basket.Add(product);
                        Console.WriteLine(product.name + " Added to basket");
                    } 
                }
            }
            Console.WriteLine("this is your current basket: ");
            foreach (Item product in basket)
            {
                totalPrice += product.price;
                Console.WriteLine(product.name);
            }
            Console.WriteLine("Subtotal: £" + totalPrice);
            Console.WriteLine("Only Cash Payment avaiable");
            Console.Write("Enter Cash Amount: ");
            double cash = Convert.ToDouble(Console.ReadLine());

            while (cash < totalPrice)
            {
                Console.WriteLine("Insufficiant Funds, Please add more: ");
                double addedCash = Convert.ToDouble(Console.ReadLine());
                cash = cash + addedCash;
            }

            double change = cash - totalPrice;
            Console.WriteLine("Please take your change: £" + change);
            Console.WriteLine("Thank you, come again!");
            Console.ReadLine();
            
             
            

            


        }
    }
}
