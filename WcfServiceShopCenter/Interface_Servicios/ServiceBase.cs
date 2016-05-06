using ClassLibraryInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceShopCenter.Interface_Servicios
{
    public class ServiceBase

    { 
        readonly IUnitOfWork _unitOfWork;
        public ServiceBase(IUnitOfWork unitOfWork)
        {
            if (null == unitOfWork)
            {
                throw new ArgumentNullException("repository");

            }
            _unitOfWork = unitOfWork;
        }
        protected int SaveChanges()
        {
            return _unitOfWork.SaveChanges();
        }
        protected  void Dispose()
        {
            _unitOfWork.Dispose();
          
        }

    }
}