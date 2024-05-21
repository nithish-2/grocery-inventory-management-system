//creating a namespace Midterm
namespace Midterm
{
    //creating a class Inventory which inherits from Item
    public class Inventory : Item
    {
        //default constructor
        public Inventory()
        {
            item = new List<Item>(); 
        }

        public List<Item> item {get; set;}

    }
}