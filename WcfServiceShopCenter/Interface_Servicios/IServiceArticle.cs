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
   public interface IServiceArticle
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetArticleList")]
        IEnumerable<Article> GetArticleList();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetArticle/{id}")]
        Article GetArticle(string id);

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/Article/Add", Method = "POST")]
        Article Add(Article article);

              



    }
}
