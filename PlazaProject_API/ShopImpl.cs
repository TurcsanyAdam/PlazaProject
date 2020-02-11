using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    public class ShopImpl : Shop
    {
        private bool isOpen { get; set; }
        private string name { get; }
        private string owner { get;}
        private Dictionary<long, ShopEntryImpl> products;
        private Random random;
        
        public ShopImpl(string name, string owner)
        {
            this.name = name;
            this.owner = owner;
            products = new Dictionary<long, ShopEntryImpl>();
            random = new Random();
        }
        private class ShopEntryImpl
        {
            public Product product { get; set; }
            public int quantity { get; set; }
            public float price { get; set; }
            public ShopEntryImpl(Product product, int quantity, float price)
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
            return isOpen;
        }

        public void Open()
        {
            isOpen = true;
        }

        public void Close()
        {
            isOpen = false;
        }

        public List<Product> GetProducts()
        {
            if (isOpen)
            {
                List<Product> onlyProductsList = new List<Product>();
                foreach (KeyValuePair<long, ShopEntryImpl> kvp in products)
                {
                    onlyProductsList.Add(kvp.Value.product);
                }
                return onlyProductsList;
            }
            else
            {
                throw new ShopIsClosedException("Shop is closed!");
            }

        }

        public Product FindByName(string name)
        {
            if (isOpen)
            {
                foreach (KeyValuePair<long, ShopEntryImpl> kvp in products)
                {
                    if (kvp.Value.product.getName() == name)
                    {
                        return kvp.Value.product;
                    }
                }
                throw new NoSuchProductException("There is no such product");
            }
            else
            {
                throw new ShopIsClosedException("Shop is closed");
            }

        }

        public bool HasProduct(long barcode)
        {
            if (isOpen)
            {
                foreach (KeyValuePair<long, ShopEntryImpl> kvp in products)
                {
                    if (kvp.Key == barcode)
                    {
                        return true;
                    }
                }
                return false;

            }
            else
            {
                throw new ShopIsClosedException("Shop is closed");
            }
        }

        public void AddNewProduct(Product product, int quantity, float price)
        {
            long randomBarcode = product.getBarcode();
            if (isOpen)
            {
                if (!products.ContainsKey(randomBarcode))
                {
                    products.Add(randomBarcode, new ShopEntryImpl(product, quantity, price));
                }
                else
                {
                    throw new ProductAlreadyExistsException("This product already exists");
                }
            }
            else
            {
                throw new ShopIsClosedException("Shop is closed");
            }

        }

        public void AddProduct(long barcode, int quantity)
        {
            if (isOpen)
            {
                foreach (KeyValuePair<long, ShopEntryImpl> kvp in products)
                {
                    if (kvp.Key == barcode)
                    {
                        kvp.Value.IncreaseQuantity(quantity);
                        break;
                    }
                    throw new ProductAlreadyExistsException("This product already exists");
                }
            }
            else
            {
                throw new ShopIsClosedException("Shop is closed");
            }

        }

        public Product BuyProduct(long barcode)
        {
            if (isOpen)
            {
                foreach (KeyValuePair<long, ShopEntryImpl> kvp in products)
                {
                    if (kvp.Key == barcode)
                    {
                        if(kvp.Value.quantity >= 1)
                        {
                            kvp.Value.DecreaseQuantity(1);
                            return kvp.Value.product;
                        }
                        else
                        {
                            throw new OutOfStockException("Out of stock");
                        }
                        
                    }
                }
                throw new ProductAlreadyExistsException("This product already exists");
            }
            else
            {
                throw new ShopIsClosedException("Shop is closed");
            }
        }

        public List<Product> BuyProducts(long barcode, int quantity)
        {
            if (isOpen)
            {
                List<Product> boughtProducts = new List<Product>();
                foreach (KeyValuePair<long, ShopEntryImpl> kvp in products)
                {
                    if (kvp.Key == barcode)
                    {
                        if (kvp.Value.quantity >= quantity)
                        {
                            kvp.Value.DecreaseQuantity(quantity);
                            for (int i = 0; i < quantity; i++)
                            {
                                boughtProducts.Add(kvp.Value.product);
                            }
                        }
                        else
                        {
                            throw new OutOfStockException("Out of stock");
                        }

                    }
                }
                throw new ProductAlreadyExistsException("This product already exists");
            }
            else
            {
                throw new ShopIsClosedException("Shop is closed");
            }
        }

        public float GetPrice(long barcode)
        {
            if (isOpen)
            {
                foreach (KeyValuePair<long, ShopEntryImpl> kvp in products)
                {
                    if (kvp.Key == barcode)
                    {
                        return kvp.Value.price;
                    }
                }
                throw new NoSuchProductException("There is no such product");
            }
            else
            {
                throw new ShopIsClosedException("Shop is closed");
            }
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
