using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCartItem 
    {


        private int _productId;
        private Product _productName = null;
        
        
        
        public int Quantity { get; set; }



        public int ProductId
        {
         get{return _productId;}
         set{ _productName = null; 
                _productId = value;}
        }

        public Product Prod

        {
            get
            {
            if(_productName == null)
                {
                    _productName = new Product(ProductId);
                }
                return _productName;
            }
            
        }
        
        public decimal itemPrice
        {
         get{ return Product.id; }
        }

        public decimal TotalPrice
        {
         get{ return itemPrice * Quantity; }
        }

        public ShoppingCartItem (int productId)
        {
            this.ProductId = productId;
        }

        public bool Equals(ShoppingCartItem item)
        {
            return item.ProductId == this.ProductId;
        }
    }

}
