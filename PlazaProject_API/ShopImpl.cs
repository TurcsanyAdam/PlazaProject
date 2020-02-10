﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    public class ShopImpl : Shop
    {
        private string name { get; }
        private string owner { get;}
        private Dictionary<long, ShopEntryImpl> products;
        
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

        }


        public bool IsOpen()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            List<Product> onlyProductsList = new List<Product>();
            foreach(KeyValuePair<long, ShopEntryImpl> kvp in products)
            {
                kvp.Value.
            }
        }

        public Product FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool HasProduct(long barcode)
        {
            throw new NotImplementedException();
        }

        public void AddNewProduct(Product product, int quantity, float price)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(long barcode, int quantity)
        {
            throw new NotImplementedException();
        }

        public Product BuyProduct(long barcode)
        {
            throw new NotImplementedException();
        }

        public List<Product> BuyProducts(long barcode, int quantity)
        {
            throw new NotImplementedException();
        }

        public float GetPrice(long barcode)
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return name;
        }

        public string GetOwner()
        {
            return owner;
        }
        public override string ToString()
        {
            string result = name + " - " + owner;
            return result;
        }
    }
}
