using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results.Abstract;
using Entity.Concrete;
using Entity.Dtos;

namespace Business.Abstract
{
    public interface IProductService : ICrudService<Product>
    {
        Task<IDataResult<List<ProductDetailDto>>> GetAllProductByGenreIdAsync(int genreId);
        Task<IDataResult<List<ProductDetailDto>>> GetAllProductByAuthorIdAsync(int authorId);
        Task<IDataResult<List<ProductDetailDto>>> GetAllProductByPublisherIdAsync(int publisherId);
        Task<IDataResult<List<ProductDetailDto>>> GetAllProductByProductImageIdAsync(int productImageId);
        Task<IDataResult<List<ProductDetailDto>>> GetAllProductByUnitPriceAsync(decimal min, decimal max);
        Task<IDataResult<List<ProductDetailDto>>> GetAllProductByProductName(string productName);
        Task<IDataResult<List<ProductDetailDto>>> GetAllProductDetailsAsync();
        IDataResult<ProductDetailDto> GetProductDetails(int productId);
    }
}
