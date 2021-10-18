using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dtos;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public async Task<IResult> AddAsync(Product entity)
        {
            await _productDal.AddAsync(entity);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> UpdateAsync(Product entity)
        {
            await _productDal.UpdateAsync(entity);
            return new SuccessResult(Messages.Updated);
        }

        public async Task<IResult> DeleteAsync(Product entity)
        {
            await _productDal.DeleteAsync(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public async Task<IDataResult<Product>> GetAsyncById(int id)
        {
            return new SuccessDataResult<Product>(await _productDal.GetAsync(p => p.ProductId == id));
        }

        public async Task<IDataResult<List<Product>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Product>>(await _productDal.GetAllAsync());
        }

        public async Task<IDataResult<List<ProductDetailDto>>> GetAllProductByGenreIdAsync(int genreId)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(
                await _productDal.GetAllProductDetailsAsync(p => p.GenreId == genreId));
        }

        public async Task<IDataResult<List<ProductDetailDto>>> GetAllProductByAuthorIdAsync(int authorId)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(
                await _productDal.GetAllProductDetailsAsync(p => p.AuthorId == authorId));
        }

        public async Task<IDataResult<List<ProductDetailDto>>> GetAllProductByPublisherIdAsync(int publisherId)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(
                await _productDal.GetAllProductDetailsAsync(p => p.PublisherId == publisherId));
        }

        public async Task<IDataResult<List<ProductDetailDto>>> GetAllProductByProductImageIdAsync(int productImageId)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(
                await _productDal.GetAllProductDetailsAsync(p => p.ProductImageId == productImageId));
        }

        public async Task<IDataResult<List<ProductDetailDto>>> GetAllProductByUnitPriceAsync(decimal min, decimal max)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(
                await _productDal.GetAllProductDetailsAsync(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<ProductDetailDto> GetProductDetails(int productId)
        {
            return new SuccessDataResult<ProductDetailDto>(
                _productDal.GetProductDetails(p => p.ProductId == productId));
        }

        public async Task<IDataResult<List<ProductDetailDto>>> GetAllProductDetailsAsync()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(await _productDal.GetAllProductDetailsAsync());
        }

    }
}
