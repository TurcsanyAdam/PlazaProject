using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    public class PlazaImpl:Plaza
    {
        private bool isOpen = false;
        private List<Shop> shops = new List<Shop>();
        private string plazaName;

        public PlazaImpl(string plazaName)
        {
            this.plazaName = plazaName;
        }

        public void AddShop(Shop shop)
        {
            shops.Add(shop);
        }

        public void Close()
        {
            isOpen = false;
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
            return shops;
        }

        public bool IsOpen()
        {
            return isOpen;
        }

        public void Open()
        {
            isOpen = true;
        }

        public void RemoveShop(Shop shop)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return plazaName;
        }
    }
}
