using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    public class ClothingProduct : Product
    {
        private string material { get; set; }
        private string type { get; set; }

        public ClothingProduct(long barcode, string name, string manufacturer, string material, string type)
        {
            this.barcode = barcode;
            this.name = name;
            this.manufacturer = manufacturer;
            this.material = material;
            this.type = type;

        }
    }
}
