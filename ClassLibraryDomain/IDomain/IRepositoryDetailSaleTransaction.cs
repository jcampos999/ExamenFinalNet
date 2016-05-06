using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDomain.IDomain
{
   public   interface IRepositoryDetailSaleTransaction
    {
        IEnumerable<DetailSaleTransaction> GetDetalleVentaList();
        DetailSaleTransaction AddDetalleVentaList(Article articles, int quantity, decimal subTotal);
   
    }
}
