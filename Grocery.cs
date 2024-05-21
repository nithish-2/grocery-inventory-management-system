//namespace Midterm
namespace Midterm
{
    //grocery class inherits from person
    public class Grocery : Person
    {
        public string storeName {get; set;}

        public string storeAddress {get;set;}

        public DateTime storeOpenTime {get;set;}

        public DateTime storeCloseTime {get;set;}

        public string inventoryList {get;set;}
    }
}
