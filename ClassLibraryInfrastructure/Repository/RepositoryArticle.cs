using ClassLibraryDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryInfrastructure
{
    public class RepositoryArticle : RepositoryBase<Article>, IRepositoryArticle
    {

        public RepositoryArticle(IRepository repositorioCliente)
            : base(repositorioCliente)
        {
        }
        public IEnumerable<Article> GetArticleList()
        {
            return Entity.Select(c => c);
        }
        public Article GetArticle(int id)
        {

            var Article = Entity.Where(c => c.Id == id).FirstOrDefault();
            if (null != Article)
                return Article;

            return new Article();
        }
        public Article Add(Article article)
        {
        
            var articles = Entity.Add(article);
            //Entity.SaveChanges();
            return articles;



        }




    }





}
