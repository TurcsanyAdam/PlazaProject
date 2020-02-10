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

        }

    }
}
