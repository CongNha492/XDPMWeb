using System;

namespace shopOnline.Models
{
    public class CartItem
    {
        public Product product { get; set; }
        public int amount { get; set; }
        public int TotalMoney => amount * product.ProductPrice.Value;
        public double TotalWeight => amount * product.Weight.Value;
        public int feeShip;
    }
}
