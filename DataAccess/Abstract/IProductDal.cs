using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entity.Concrete;
using Entity.Dtos;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        Task<List<ProductDetailDto>> GetAllProductDetailsAsync(
            Expression<Func<ProductDetailDto, bool>> expression = null);
        ProductDetailDto GetProductDetails(Expression<Func<ProductDetailDto, bool>> expression);
    }
}

