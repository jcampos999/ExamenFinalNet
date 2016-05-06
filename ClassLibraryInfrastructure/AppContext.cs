using ClassLibraryDomain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryInfrastructure
{

    public partial class AppContext : DbContext, IUnitOfWork, IRepository
    {
    

        public AppContext()
            : base("DefaultConnection")
        {
           
        }

        public IDbSet<Article> Article { get; set; }
        public IDbSet<DetailSaleTransaction> DetailSale { get; set; }
        public IDbSet<SaleTransaction> Sale { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var cn = this.Database.Connection.ConnectionString;
            base.OnModelCreating(modelBuilder);

        }


        public IDbSet<TEntity> GetSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

       


    }
}
