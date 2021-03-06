﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    public abstract class Product
    {
        protected long barcode { get; set; }
        protected string name { get; set; }
        protected string manufacturer { get; set; }
        protected Product ()
        {
        }

        public long getBarcode()
        {
            return barcode;
        }
        public string getName()
        {
            return name;
        }
        public string getManufacturer()
        {
            return manufacturer;
        }
        public override string ToString()
        {
            return name + "-" + barcode;
        }
    }
}
