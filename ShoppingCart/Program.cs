using System;
using ShoppingLibrary;
using System.Collections.Generic;



namespace ShoppingCartApp
{
    public class Program
    {
 

        static void Main(string[] args)
        {

            ShoppingCart cart = new ShoppingCart();
            ShoppingCartItem item = new ShoppingCartItem("Xbox", 3960.99);

            cart.AShoppingCart(item);

            item = new ShoppingCartItem("PS4", 5999.49);

            cart.AShoppingCart(item);

            List<ShoppingCartItem> items = cart.List();

            foreach(ShoppingCartItem i in items)
            {
                Console.WriteLine(i.ProductName + "      R" + Math.Round(i.ItemPrice,2));
            }
            Console.WriteLine( "________________________"
                + "\n" + "Subtotal: R" + cart.SubTotal()
                + "\n" + "Vat:      R" + cart.Vat());
        } 
    }
}
