using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProjectAPI
{
    interface Shop
    {
        private string GetName()
        {

        }

        private string GetOwner()
        {

        }
        private bool IsOpen()
        {

        }
        private void Open()
        {

        }
        private void Close()
        {

        }
        private List<Products> GetProducts()
        {

        }
        private Product FindByName(string name)
        {

        }
        private float GetPrice(long barcode)
        {
            
        }
        private bool HasProduct(long barcode)
        {

        }
        private void AddNewProduct(Product product, int quantity, float price)
        {

        }
        private void AddProduct(long barcode, int quantity)
        {

        }
        private Product BuyProduct(long barcode)
        {

        }
        private List<Product> BuyProducts(long barcode, int quantity)
        {

        }
        private string ToString();
    }
}
