using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDomain
{
   public class SaleTransaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public IEnumerable<DetailSaleTransaction> DetailTransaction { get; set; }
    }
}
