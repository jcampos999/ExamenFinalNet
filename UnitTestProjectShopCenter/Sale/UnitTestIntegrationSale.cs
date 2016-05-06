using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryDomain;
using ClassLibraryInfrastructure;
using WcfServiceShopCenter;
using System.Collections.Generic;

namespace UnitTestProjectShopCenter
{
    [TestClass]
    public class UnitTestIntegrationSale
    {

        private IServiceSale _serviceSale;
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
        public void TestMethodIntegrationSale()
        {
            //Arrange
             using (var context = new AppContext())
            {
                _serviceSale = new ServiceSale(new RepositorySaleTransaction(context), context);
                context.Sale.Add(new SaleTransaction() { Total = 2 });
                context.SaveChanges();
            }
            //Act
             List<SaleTransaction> result = _serviceSale.GetVentaList() as List<SaleTransaction>;
            //Assert
            Assert.AreEqual(MovieCount, result.Count);

        }


        [TestMethod]
        public void TestMethodIntegrationSaleSave()
        {
            //Arrange
            using (var context = new AppContext())
            {
                _serviceSale = new ServiceSale(new RepositorySaleTransaction(context), context);
                //Act
                var sale = context.Sale.Add(new SaleTransaction() { Total = 2 });

                context.SaveChanges();
                //Assert
                Assert.AreNotEqual(null, sale);
            }
        }


    }
}
