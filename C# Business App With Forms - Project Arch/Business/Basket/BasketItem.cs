using Business.Base;
using P = Business.Product;
using System;
// https://www.geeksforgeeks.org/how-to-use-namespace-alias-qualifier-in-c-sharp/

namespace Business.Basket
{
    public class BasketItem : IBase, IActivity
    {
        public int ID { get; set; }
        public Basket Basket { get; set; }
        public P::Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
