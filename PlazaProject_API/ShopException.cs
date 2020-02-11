using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    public class ShopException:Exception
    {
        public ShopException()
        {

        }

        public ShopException(string message)
            : base(message)
        {

        }

    }
}
