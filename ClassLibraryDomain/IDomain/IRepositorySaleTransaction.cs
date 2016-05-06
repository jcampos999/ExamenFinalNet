using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDomain
{
    public interface IRepositorySaleTransaction
    {
        SaleTransaction AddVentaList(SaleTransaction saleTransaction);
        IEnumerable<SaleTransaction> GetVentaList();
       

    }
}
