using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProjectAPI
{
    class ShopImpl : Shop
    {
        private string name { get; set; }
        private string owner { get; set; }
        private Dictionary<long, ShopImpl.ShopEntryImpl> products;
        
        public ShopImpl(string name, string owner)
        {
            this.name = name;
            this.owner = owner;
        }
        private class ShopEntryImpl
        {
            private Product product { get; set; }
            private int quantity { get; set; }
            private float price { get; set; }
            private ShopEntryImpl(Product product, int quantity, float price)
            {
                this.product = product;
                this.quantity = quantity;
                this.price = price;
            }

            public void IncreaseQuantity(int amount)
            {
                quantity += amount;
            }

            public void DecreaseQuantity(int amount)
            {
                quantity -= amount;
            }
            public string ToString()
            {

            }

        }

    }
}
