using System;
using System.Collections.Generic;
using System.Text;
using product;
using Vending.M.Interface;

namespace Vending.M.Data
{
    class VendingMachineService: Ivending

    {
        List<Product> products = new List<Product>();

        Till moneyPool= new Till();
        Product Ivending.Purchase()
        {
            throw new NotImplementedException();
        }

        List<string> Ivending.ShowAll()
        {
            throw new NotImplementedException();
        }


        string Ivending.Details(Product product)
        {
            throw new NotImplementedException();
        }

        void Ivending.InsertMoney()

        {
            throw new NotImplementedException();
        }

        int Ivending.EndTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
