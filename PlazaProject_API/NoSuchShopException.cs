using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    class NoSuchShopException:ShopException
    {
        public NoSuchShopException()
        {

        }

        public NoSuchShopException(string message)
            : base(message)
        {

        }
    }
}
