using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        /*
         Buraya sadece ürüne ait özel operasyonların imzası, EfProductDal'da implemente et.

         List<ProductDto> GetDetails();
         */

        List<ProductDetailDto> GetProductDetails();
    }
}
