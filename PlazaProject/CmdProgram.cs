using System;
using System.Collections.Generic;
using System.Text;
using PlazaProject_API;

namespace PlazaProject
{
    class CmdProgram
    {
        private List<Product> cart; 
        private List<float> prices;

        public CmdProgram(string[] args)
        {

        }

        public void Run()
        {
            PlazaImpl plaza = null;

            string firstMenu = "There are no plaza created yet! Press\n" +
                               "1) to create a new plaza.\n" +
                               "2) to exit.\n";

            Console.Write(firstMenu);
            var inputFirstMenu = Console.ReadKey(true);
            switch (inputFirstMenu.Key)
            {
                case ConsoleKey.D1:
                    Console.Write("Enter the name of the Plaza here: ");
                    string plazaName = Console.ReadLine();
                    plaza = new PlazaImpl(plazaName);
                    Console.Clear();
                    string secondMenu = $"Welcome to the {plaza.ToString()}! Press\n" +
                    "1) to list all shops.\n" +
                    "2) to add a new shop.\n" +
                    "3) to remove an existing shop.\n" +
                    "4) find a shop by name.\n" +
                    "5) to check if the plaza is open or not.\n" +
                    "6) to open the plaza.\n" +
                    "7) to close the plaza.\n" +
                    "...\n" +
                    "N) leave plaza.\n";
                    while (true)
                    {
                        Console.Clear();
                        Console.Write(secondMenu);
                        var inputSecondMenu = Console.ReadKey(true);
                        switch (inputSecondMenu.Key)
                        {
                            case ConsoleKey.D1:
                                foreach (Shop shop in plaza.GetShops())
                                {
                                    Console.WriteLine(shop.ToString());
                                }
                                Console.ReadLine();
                                break;
                            case ConsoleKey.D2:
                                Console.Write("Enter the name of the store here: ");
                                string storeName = Console.ReadLine();
                                Console.Write("Enter the name of the owner of the store here: ");
                                string storeOwner = Console.ReadLine();
                                ShopImpl shopImpl = new ShopImpl(storeName, storeOwner);
                                plaza.AddShop(shopImpl);
                                break;
                            case ConsoleKey.D3:
                                Console.Write("Enter the name of the store you want to remove here: ");
                                string storeToBeRemoved = Console.ReadLine();
                                plaza.RemoveShop(plaza.FindShopByName(storeToBeRemoved));
                                break;
                            case ConsoleKey.D4:
                                Console.Write("Enter the name of the store you want to remove here: ");
                                string storeToBeUsed = Console.ReadLine();
                                ShopImpl currentShop = (ShopImpl)plaza.FindShopByName(storeToBeUsed);
                                string thirdMenu = $"Hi! This is the {currentShop.ToString()} , welcome! Press\n" +
                                                   "1) to list available products.\n" +
                                                   "2) to find products by name.\n" +
                                                   "3) to display the shop's owner.\n" +
                                                   "4) to open the shop.\n" +
                                                   "5) to close the shop.\n" +
                                                   "6) to add new product to the shop.\n" +
                                                   "7) to add existing products to the shop.\n" +
                                                   "8) to buy a product by barcode.\n" +
                                                   "9) check price by barcode.\n" +
                                                   "...\n" +
                                                   "N) go back to plaza.\n";
                                while (true)
                                {
                                    Console.Clear();
                                    Console.Write(thirdMenu);
                                    var inputThirdMenu = Console.ReadKey(true);
                                    switch (inputThirdMenu.Key)
                                    {
                                        case ConsoleKey.D1:
                                            foreach(KeyValuePair kvp in currentShop.GetProducts)
                                            break;
                                        case ConsoleKey.D2:
                                            break;
                                        case ConsoleKey.D3:
                                            break;
                                        case ConsoleKey.D4:
                                            break;
                                        case ConsoleKey.D5:
                                            break;
                                        case ConsoleKey.D6:
                                            break;
                                        case ConsoleKey.D7:
                                            break;
                                        case ConsoleKey.D8:
                                            break;
                                        case ConsoleKey.D9:
                                            break;
                                        case ConsoleKey.N:                                            
                                            break;
                                    }
                                    break;
                                }
                                break;
                            case ConsoleKey.D5:
                                Console.WriteLine(plaza.IsOpen());
                                break;
                            case ConsoleKey.D6:
                                plaza.Open();
                                break;
                            case ConsoleKey.D7:
                                plaza.Close();
                                break;
                            case ConsoleKey.N:
                                Environment.Exit(0);
                                break;
                            default:
                                throw new ArgumentException("Invalid input");

                        }
                    }
                    
                    break;
                case ConsoleKey.D2:
                    Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentException("Invalid input");
            }
        }
    }
}
