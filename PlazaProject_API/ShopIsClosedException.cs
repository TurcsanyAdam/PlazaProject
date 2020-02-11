using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    class ShopIsClosedException:ShopException
    {
        public ShopIsClosedException()
        {

        }

        public ShopIsClosedException(string message)
            : base(message)
        {

        }
    }
}
