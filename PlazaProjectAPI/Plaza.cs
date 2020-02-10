using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProjectAPI
{
    public interface Plaza
    {
        public List<Shop> GetShops()
        {

        }
        public void AddShop(Shop shop)
        {

        }
        public void RemoveShop(Shop shop)
        {

        }
        public Shop FindShopByName(string name)
        {

        }
        public bool IsOpen()
        {

        }
        public void Open()
        {

        }
        public void Close()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
