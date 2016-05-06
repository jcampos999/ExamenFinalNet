using ClassLibraryDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceShopCenter
{
    

    [ServiceContract]

    public interface IServiceSale
    {

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddVentaList", Method = "POST")]
        SaleTransaction AddVentaList(SaleTransaction saleTransaction);


        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetVentaList")]
        IEnumerable<SaleTransaction> GetVentaList();

    }


}
