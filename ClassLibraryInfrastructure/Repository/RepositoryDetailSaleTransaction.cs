using ClassLibraryDomain;
using ClassLibraryDomain.IDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryInfrastructure
{
  

    public class RepositoryDetailSaleTransaction : RepositoryBase<DetailSaleTransaction>, IRepositoryDetailSaleTransaction
    {


        public RepositoryDetailSaleTransaction(IRepository repositorioCliente)
            : base(repositorioCliente)
        {

        }

        public IEnumerable<DetailSaleTransaction> GetDetalleVentaList()
        {
            return Entity.Select(c => c); ;

        }


        public DetailSaleTransaction AddDetalleVentaList(Article articles, int quantity, decimal subTotal)
        {

            DetailSaleTransaction detailSaleTransaction = new DetailSaleTransaction() { Article = articles, Quantity = quantity, SubTotal = subTotal };
            var detailST = Entity.Add(detailSaleTransaction);

            //_repositorioCliente.SaveChanges();
            return detailST;
        }


    }

}
