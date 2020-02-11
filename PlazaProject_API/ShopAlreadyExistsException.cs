using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    class ShopAlreadyExistsException:ShopException
    {
        public ShopAlreadyExistsException()
        {

        }

        public ShopAlreadyExistsException(string message)
            : base(message)
        {

        }
    }
}
