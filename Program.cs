/* 
MIDTERM W23 PROG8145
===================
NAME: Nithish Jagadeesan
STUDENT ID: 8875048
EMAIL: nithish.jagadeesan@gmail.com
DATE: 23-02-2023
*/

//creating namespace Midterm
namespace Midterm
{
    //creating class called program
    class Program
    {
        //creating a main function
        static void Main(string[] args)
        {
            //instantiating inventorylist object
            InventoryList inventoryList = new InventoryList();

            //creating grocery object
            Grocery grocery = new Grocery();

            //adding elements to grocery object
            grocery.storeName = "Nithish's Grocery Store";
            grocery.storeAddress = "275 Larch Street";
            grocery.firstName = "Nithish";
            grocery.lastName = "Jagadeesan";
            DateTime now = DateTime.Now;

            //displaying store information
            Console.Clear();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Welcome to " + grocery.storeName + ", " + grocery.storeAddress);
            Console.WriteLine("Open Time: 9AM" + "       " + "Close Time: 9PM");
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine("Inventory List: Apple, Orange, Watermelon");
            Console.WriteLine("Store Owner Name: " + grocery.firstName + " " + grocery.lastName);
            Console.WriteLine("********************************************************************");

            //creating three inventory objects
            Inventory inventory1 = new Inventory();
            Inventory inventory2 = new Inventory();
            Inventory inventory3 = new Inventory();

            //adding hardcoded values in inventory
            inventory1.itemName = "Apple";
            inventory1.quantityInStock = 120;
            inventory1.pricePerUnit = 9.89;
            inventoryList.inventoryList.Add(inventory1);

            inventory2.itemName = "Orange";
            inventory2.quantityInStock = 115;
            inventory2.pricePerUnit = 12.54;
            inventoryList.inventoryList.Add(inventory2);

            inventory3.itemName = "Watermelon";
            inventory3.quantityInStock = 148;
            inventory3.pricePerUnit = 8.9;
            inventoryList.inventoryList.Add(inventory3);

            bool mainMenu = true;
            while (mainMenu)
            {
                //instantiating inventory object
                Inventory inventory = new Inventory();

                //displaying menu options
                Console.WriteLine();
                Console.WriteLine("********************************************************************");
                Console.WriteLine("1. Add a new item to the inventory");
                Console.WriteLine("2. Display all inventory items");
                Console.WriteLine("3. Clear Inventory");
                Console.WriteLine("4. Delete an item from the inventory");
                Console.WriteLine("5. Exit");
                Console.WriteLine("********************************************************************");
                string mainMenuOption = Console.ReadLine();

                //1. Add a new item to the inventory
                if (mainMenuOption == "1")
                { 
                    //getting item name
                    bool enterName = true;
                    while (enterName)
                    {
                        Console.WriteLine("********************************************************************");
                        Console.WriteLine("Enter the item name: ");
                        inventory.itemName = Console.ReadLine();

                        if (!validateName(inventory.itemName))
                        {
                            Console.WriteLine("*************************************");
                            Console.WriteLine("Please enter a valid name!");
                            Console.WriteLine("*************************************");
                            enterName = true;
                        }
                        else
                        {
                            enterName = false;
                        }
                    }

                    //getting item quantity
                    do
                    {
                        Console.WriteLine("********************************************************************");
                        Console.WriteLine("Enter the quantity in stock:(in lbs) ");
                        try
                        {
                            inventory.quantityInStock = double.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("*************************************");
                            Console.WriteLine("Please enter a valid quantity!");
                            Console.WriteLine("*************************************");
                        }
                    } while (true);

                    //getting item price
                    do
                    {
                        Console.WriteLine("********************************************************************");
                        Console.WriteLine("Enter the price per unit: ");
                        try
                        {
                            inventory.pricePerUnit = double.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("*************************************");
                            Console.WriteLine("Please enter a valid price!");
                            Console.WriteLine("*************************************");
                        }
                    } while (true);

                    //adding item name, quantity and price to the inventory list
                    inventoryList.inventoryList.Add(inventory);

                }

                //2. Display all inventory items
                else if (mainMenuOption == "2")
                {
                    //diaplays items in the inventory
                    if (inventoryList.inventoryList.Count >= 1)
                    {
                        inventoryList.Output();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("********************************************************************");
                        Console.WriteLine("No items present in the inventory");
                        Console.WriteLine("********************************************************************");
                    }
                }

                //3. Clear Inventory
                else if (mainMenuOption == "3")
                {
                    //clears inventory list
                    inventoryList.inventoryList.Clear();
                    Console.Clear();
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Inventory is Cleared");
                    Console.WriteLine("*************************************");
                }

                //4. Delete an item from the inventory
                else if (mainMenuOption == "4")
                {
                    //removes item from inventory
                    bool removeItem = true;
                    while (removeItem)
                    {
                        if (inventoryList.inventoryList.Count >= 1)
                        {
                            inventoryList.Output();
                            Console.WriteLine("********************************************************************");
                            Console.WriteLine("Enter the number of item to be deleted: ");
                            string itemNumberString = Console.ReadLine();
                            int itemNumber;
                            bool validateItemNumber = int.TryParse(itemNumberString, out itemNumber);
                            if (!validateItemNumber)
                            {
                                Console.WriteLine("********************************************************************");
                                Console.WriteLine("Please enter a valid input!");
                                Console.WriteLine("********************************************************************");
                                removeItem = true;
                            }
                            else if (validateItemNumber)
                            {
                                removeItem = false;
                                inventoryList.inventoryList.RemoveAt(--itemNumber);
                                Console.WriteLine("Item " + (++itemNumber) + " removed");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("********************************************************************");
                            Console.WriteLine("No items present in the inventory");
                            Console.WriteLine("********************************************************************");
                        }
                    }
                }

                //5. Exit
                else if (mainMenuOption == "5")
                {
                    Console.Clear();
                    Console.WriteLine("********************************");
                    Console.WriteLine("Thank You!");
                    Console.WriteLine("********************************");
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("Please enter a valid input !");
                    Console.WriteLine("********************************");
                    mainMenu = true;
                }

            }
        }

        //function to validate whether entered string is valid or not
        public static bool validateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            else if (name.Any(char.IsDigit))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}