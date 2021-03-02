using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManeger : EfProductDal
    {
       
        private EfProductDal efProductDal;

        //public ProductManeger(IProductDal productDal)
        //{
        //    _productDal = productDal;  
        //}
        public ProductManeger(EfProductDal efProductDal)
        {
            this.efProductDal = efProductDal;
        }
        public List<Entities.Concrete.Product> GetAll()
        {
            //İş Kodları
            return efProductDal.GetAll();
        }
    }
}
