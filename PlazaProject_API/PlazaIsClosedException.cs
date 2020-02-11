using System;
using System.Collections.Generic;
using System.Text;

namespace PlazaProject_API
{
    public class PlazaIsClosedException:ShopException
    {
        public PlazaIsClosedException()
        {

        }

        public PlazaIsClosedException(string message)
            : base(message)
        {

        }
    }
}
