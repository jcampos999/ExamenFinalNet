using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryInfrastructure
{
  
        public class RepositoryBase<T> where T : class
        {
            readonly IRepository _context;
            public RepositoryBase(IRepository context)
            {
                if (null == context)
                {
                    throw new ArgumentNullException("context");

                }
                _context = context;
            }
            protected IDbSet<T> Entity
            {
                get
                {
                    return _context.GetSet<T>();
                }
            }
            //protected void Modify(T entity)
            //{
            //    _context.Entry<T>(entity).State = System.Data.EntityState.Modified;
            //}
        }
    
}
