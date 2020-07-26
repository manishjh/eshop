using System;

namespace BusinessObjects
{
    public class ProductDetail
    {
        //starting with a int product Id, may need to change this to GUID
        public int ProductId {get;}
        public string Description { get; set; }
        public decimal UnitPrice { get; }
        public long UnitWeightGms {get;}

        public int QuantityPerUnit {get;}

        public int DiscountPercentage { get; }

        public string ImageUrl {get;}
    }
}