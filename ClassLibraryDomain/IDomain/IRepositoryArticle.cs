using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDomain
{
    public interface IRepositoryArticle
    {
        IEnumerable<Article> GetArticleList();
        Article GetArticle(int id);
        Article Add(Article article);
    }
}
