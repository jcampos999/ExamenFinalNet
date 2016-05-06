using ClassLibraryDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryInfrastructure
{
  

    public class RepositorySaleTransaction : RepositoryBase<SaleTransaction>, IRepositorySaleTransaction
    {
        

        public RepositorySaleTransaction(IRepository repositorioCliente)
            : base(repositorioCliente)
        {

        }

        public SaleTransaction AddVentaList(SaleTransaction saleTransaction)
        {
            var sT = Entity.Add(saleTransaction);
            return sT;
        }

        public IEnumerable<SaleTransaction> GetVentaList()
        {
            return Entity;
        }



    }


}
