using ClassLibraryDomain;
using ClassLibraryInfrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceShopCenter;




namespace UnitTestProjectShopCenter
{
     

     [TestClass]
     public class UnitTestUnitario
     {
         private MockFactory _factory = new MockFactory();

         [TestCleanup]
         public void Cleanup()
         {
             _factory.VerifyAllExpectationsHaveBeenMet();
             _factory.ClearExpectations();
         }


         [TestMethod]
         public void NumberOfArticleEqualsOne()
         {
          
             var repository = _factory.CreateMock<IRepositoryArticle>();
             var unitOfWork = _factory.CreateMock<IUnitOfWork>();
             var servicieArticle = new ServiceArticle( repository.MockObject, unitOfWork.MockObject);
              
             var article = new HashSet<Article>() {
                 new Article() {Name = "pera"}
             };
             repository.Expects.One.Method(c => c.GetArticleList()).WillReturn(article);
             unitOfWork.Expects.One.Method(c => c.Dispose());

           
             var result = (servicieArticle.GetArticleList()) as List<Article>;
            
          
             Assert.AreEqual(1, result.Count);
         }


         [TestMethod]
         public void NumberOfArticleEqualsOneSave()
         {

             var repository = _factory.CreateMock<IRepositoryArticle>();
             var unitOfWork = _factory.CreateMock<IUnitOfWork>();
             var servicieArticle = new ServiceArticle(repository.MockObject, unitOfWork.MockObject);

             var article = new HashSet<Article>() {
                 new Article() {Name = "pera"}
             };
             //repository.Expects.One.Method(c => c.Add(article)).WillReturn(article);
             //unitOfWork.Expects.One.Method(c => c.Dispose());


             //var result = (servicieArticle.Add(article)) ;


             //Assert.AreEqual(1, result.Count);
         }

     }


}
