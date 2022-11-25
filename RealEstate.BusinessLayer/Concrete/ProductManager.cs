using RealEstate.BusinessLayer.Abstract;
using RealEstate.DataAccessLayer.Abstract;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.BusinessLayer.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }

        public void TDelete(Product t)
        {
           _productDal.Delete(t);
        }

        public Product TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Product t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
