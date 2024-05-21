//creating a namespace Midterm
namespace Midterm
{
    //creating a class called InventoryList which inherits from Inventory
    public class InventoryList : Inventory
    {
        // inventoryList
        public List<Inventory> inventoryList {get;set;}

        //default constructor
        public InventoryList()
        {
            inventoryList = new List<Inventory>();
        }

        //Output function to display desired output
        public void Output(){
            int count = 0;
            double totalPrice = 0;
            foreach (Inventory invent in inventoryList){
                Console.WriteLine("********************************************************************");
                Console.WriteLine("Item "+(++count));
                Console.WriteLine("Item Name: "+invent.itemName);
                Console.WriteLine("Quantity in Stock: "+invent.quantityInStock);
                Console.WriteLine("Price per unit: "+invent.pricePerUnit);
                Console.WriteLine("Total Price of the item: "+String.Format("{0 : 0.##}", (invent.quantityInStock * invent.pricePerUnit)));
                totalPrice = totalPrice + (invent.quantityInStock * invent.pricePerUnit);
            }
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Total Price of the entire inventory: "+String.Format("{0 : 0.##}", totalPrice));
            Console.WriteLine();
        }
    }
}