using System;

namespace BusinessObjects
{
    public class Product
    {        //starting with a int product Id, may need to change this to GUID
        static int id = 0;
        public Product(string name)
        {
            Id = id++;
            Name = name;
        }
        public int Id { get; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public ProductInventory Inventory { get; set; }
        public ProductDetail Detail { get; set; }
    }
}
