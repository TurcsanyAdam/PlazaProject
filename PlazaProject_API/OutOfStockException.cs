using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    class OutOfStockException :Exception
    {
        public OutOfStockException()
        {

        }

        public OutOfStockException(string message)
            : base(message)
        {

        }
    }
}
