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
            if (isOpen)
            {
                if (!shops.Contains(shop))
                {
                    shops.Add(shop);

                }
                else
                {
                    throw new ShopAlreadyExistsException("This shop already exists");
                }
            }
            else
            {
                throw new PlazaIsClosedException("Plaza is closed");
            }
        }

        public void Close()
        {
            isOpen = false;
        }

        public Shop FindShopByName(string name)
        {
            if (isOpen)
            {
                foreach (Shop shop in shops)
                {
                    if (shop.GetName() == name)
                    {
                        return shop;
                    }
                }
                throw new NoSuchShopException("This shop doesn't exist");
            }
            else
            {
                throw new PlazaIsClosedException("Plaza is closed");
            }
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
            if (isOpen)
            {
                if (shops.Contains(shop))
                {
                    shops.Remove(shop);

                }
                else
                {
                    throw new NoSuchShopException("This shop doesn't exist");
                }
            }
            else
            {
                throw new PlazaIsClosedException("Plaza is closed");
            }
        }
        public override string ToString()
        {
            return plazaName;
        }
    }
}
