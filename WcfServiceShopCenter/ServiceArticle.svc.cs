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
    

    public class ServiceArticle : ServiceBase ,  IServiceArticle
    {

        readonly IRepositoryArticle _repositorioArticle;
       

        public ServiceArticle(IRepositoryArticle repositorioArticle, IUnitOfWork unitOfWork)
            :base (unitOfWork)
        {

            if (null == repositorioArticle)
            {
                throw new ArgumentNullException("repositorioArticle");

            }
            _repositorioArticle = repositorioArticle;
          
        }

        public IEnumerable<Article> GetArticleList()
        {
            return _repositorioArticle.GetArticleList();

        }

        public Article GetArticle(string id)
        {
            return _repositorioArticle.GetArticle(int.Parse(id));
        }

        public Article Add(Article article)
        {
            var add = _repositorioArticle.Add(article);
            SaveChanges();
            return add;
        }


    }

}
