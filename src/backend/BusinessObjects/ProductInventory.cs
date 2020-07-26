using System;

namespace BusinessObjects
{
    public class ProductInventory
    {
        //starting with a int product Id, may need to change this to GUID
        public int ProductId {get;}    
        public int UnitsOnOrder { get; set; }
        public int UnitsInStock { get; set; }
        public int ReorderLevel { get; set; }
    }
}