using System;
using System.Collections.Generic;
using System.Text;
using Product;

namespace Vending.M.Interface
{
    interface Ivending
    {
        Product Purchase();
        List<string> ShowAll();
        String Details(Product product);
        void InsertMoney();
        int EndTransaction();
    }
}
