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
     public class UnitTestUnitarioSale
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
          
             var repository = _factory.CreateMock<IRepositorySaleTransaction>();
             var unitOfWork = _factory.CreateMock<IUnitOfWork>();
             var servicieArticle = new ServiceSale ( repository.MockObject, unitOfWork.MockObject);
              
             var sale = new HashSet<SaleTransaction>() {
                 new SaleTransaction() { Total =10 , 
                     DetailTransaction = new 
                                             List<DetailSaleTransaction> ()
                                             {  new  DetailSaleTransaction  (){ SubTotal =10}  ,
                                                 new  DetailSaleTransaction (){ SubTotal =10} } 
                   }
             };
             repository.Expects.One.Method(c => c.GetVentaList()).WillReturn(sale);
             unitOfWork.Expects.One.Method(c => c.Dispose());

             var result = (servicieArticle.GetVentaList()) as List<SaleTransaction>;
            
             Assert.AreEqual(1, result.Count);
         }
     }


}
