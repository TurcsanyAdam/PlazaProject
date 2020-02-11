using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    class ProductAlreadyExistsException:ShopException
    {
        public ProductAlreadyExistsException()
        {

        }

        public ProductAlreadyExistsException(string message)
            : base(message)
        {

        }
    }
}
