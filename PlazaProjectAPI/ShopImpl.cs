using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProjectAPI
{
    class ShopImpl : Shop
    {
        public string name { get; set; }
        public string owner { get; set; }
        public Dictionary<long, ShopImpl.ShopEntryImpl> products;
        
        private ShopImpl(string name, string owner)
        {
            this.name = name;
            this.owner = owner;
        }

    }
}
