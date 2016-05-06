using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDomain
{
   public  class DetailSaleTransaction
    {
        public int Id { get; set; }
        public Article Article { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }

    }
}
