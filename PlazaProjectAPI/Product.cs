using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProjectAPI
{
    abstract class Product
    {
        protected long barcode { get; }
        protected string name { get; }
        protected string manufacturer { get; }
        protected Product (long barcode, string name, string manufacturer)
        {
            this.barcode = barcode;
            this.name = name;
            this.manufacturer = manufacturer;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
