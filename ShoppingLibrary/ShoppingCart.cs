using System;
using System.Collections.Generic;

namespace ShoppingLibrary
{

    public class ShoppingCart
    {

        private List<ShoppingCartItem> cartItems = new List<ShoppingCartItem>();

        public void AShoppingCart(ShoppingCartItem item) => cartItems.Add(item);

        public List<ShoppingCartItem> List()
        {
            return cartItems;
        }




        public double SubTotal()
        {
            double total = 0;

            foreach (ShoppingCartItem item in cartItems)
            {
                total += item.ItemPrice;

                return total;
            }
            return Math.Round(total,2);
        }

        public double Vat()
        {
            double Vat = 0;
            Vat = SubTotal() + SubTotal()*0.15;
            return Math.Round(Vat,2);
        } 

    }
}
