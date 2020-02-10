using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    public class FoodProduct : Product
    {
        private int calories { get; }
        private DateTime bestBefore;
        public FoodProduct(long barcode, string name, string manufacturer, int calories, DateTime bestBefore)
        {
            this.barcode = barcode;
            this.name = name;
            this.manufacturer = manufacturer;
            this.calories = calories;
            this.bestBefore = bestBefore;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
