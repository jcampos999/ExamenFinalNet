using ClassLibraryDomain;
using ClassLibraryInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceShopCenter.Interface_Servicios;

namespace WcfServiceShopCenter
{


    public class ServiceSale : ServiceBase , IServiceSale
    {


        readonly IRepositorySaleTransaction _repositorioSale;
     

        public ServiceSale(IRepositorySaleTransaction repositorioSale, IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _repositorioSale = repositorioSale;
           
        }


        public SaleTransaction AddVentaList(SaleTransaction saleTransaction)
        {
            var saleTransaccion = _repositorioSale.AddVentaList(saleTransaction);
            SaveChanges();
            return saleTransaccion;
        }

        public IEnumerable<SaleTransaction> GetVentaList()
        {
            return _repositorioSale.GetVentaList();

        }


    }


}
