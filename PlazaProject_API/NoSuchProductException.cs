using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    class NoSuchProductException:ShopException
    {
        public NoSuchProductException()
        {

        }

        public NoSuchProductException(string message)
            : base(message)
        {

        }
    }
}
