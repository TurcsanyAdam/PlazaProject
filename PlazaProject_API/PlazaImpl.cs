using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    public class PlazaImpl:Plaza
    {
        private List<Shop> shops;

        public PlazaImpl()
        {

        }

        public void AddShop(Shop shop)
        {
            shops.Add(shop);
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public Shop FindShopByName(string name)
        {
            foreach(Shop shop in shops)
            {
                if(shop.GetName() == name)
                {
                    return shop;
                }
                else
                {
                    throw new Exception();
                }
            }
            throw new Exception();

        }

        public List<Shop> GetShops()
        {
            throw new NotImplementedException();
        }

        public bool IsOpen()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void RemoveShop(Shop shop)
        {
            throw new NotImplementedException();
        }
    }
}
