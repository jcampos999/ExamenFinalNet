using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryDomain;
using ClassLibraryInfrastructure;
using WcfServiceShopCenter;
using System.Collections.Generic;

namespace UnitTestProjectShopCenter
{
    [TestClass]
    public class UnitTestIntegration
    {

        private IServiceArticle _serviceArticle;
        private readonly int MovieCount = 1;
        [TestInitialize]
        public void CreateDatabase()
        {
             using (var context = new AppContext())
            {
               if (context.Database.Exists())
                {
                    context.Database.Delete();
                }
                context.Database.Create();
            }
        }


        [TestMethod]
        public void TestMethodIntegrationArticle()
        {
            //Arrange
             using (var context = new AppContext())
            {
                _serviceArticle = new ServiceArticle(new RepositoryArticle(context), context);
                context.Article.Add(new Article() { Id = 1, Name = "Pera", Price = 3 });
                context.SaveChanges();
            }
            //Act
            List<Article> result = _serviceArticle.GetArticleList() as  List<Article>;
            //Assert
            Assert.AreEqual(MovieCount, result.Count);

        }

        [TestMethod]
        public void TestMethodIntegrationArticleSave()
        {
            //Arrange
            using (var context = new AppContext())
            {
                _serviceArticle = new ServiceArticle(new RepositoryArticle(context), context);
                //Act
                var article = context.Article.Add(new Article() { Id = 1, Name = "Pera", Price = 3 });
                context.SaveChanges();
                //Assert
                Assert.AreNotEqual(null, article);
            }
        }


    }
}
