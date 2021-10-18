using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entity.Concrete;
using Entity.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, BookContext>, IProductDal
    {
        public ProductDetailDto GetProductDetails(Expression<Func<ProductDetailDto, bool>> expression)
        {
            using (BookContext context = new BookContext())
            {
                var result = from p in context.Products
                             join g in context.Genres on p.GenreId equals g.GenreId
                             join a in context.Authors on p.AuthorId equals a.AuthorId
                             join pl in context.Publishers on p.PublisherId equals pl.PublisherId
                             join pi in context.ProductImages on p.ProductImageId equals pi.Id
                             select new ProductDetailDto()
                             {
                                 ProductId = p.ProductId,
                                 AuthorId = a.AuthorId,
                                 GenreId = g.GenreId,
                                 PublisherId = pl.PublisherId,
                                 ProductImageId = pi.Id,
                                 ProductName = p.ProductName,
                                 Description = p.Description,
                                 UnitPrice = p.UnitPrice,
                                 AuthorName = a.AuthorName,
                                 GenreName = g.GenreName,
                                 PublisherName = pl.PublisherName,
                                 ImagePath = pi.ImagePath
                             };
                return result.SingleOrDefault(expression);

            }
        }

        public async Task<List<ProductDetailDto>> GetAllProductDetailsAsync(Expression<Func<ProductDetailDto, bool>> expression = null)
        {
            using (BookContext context = new BookContext())
            {
                var result = from p in context.Products
                             join g in context.Genres on p.GenreId equals g.GenreId
                             join a in context.Authors on p.AuthorId equals a.AuthorId
                             join pl in context.Publishers on p.PublisherId equals pl.PublisherId
                             join pi in context.ProductImages on p.ProductImageId equals pi.Id
                             select new ProductDetailDto()
                             {
                                 ProductId = p.ProductId,
                                 AuthorId = a.AuthorId,
                                 GenreId = g.GenreId,
                                 PublisherId = pl.PublisherId,
                                 ProductImageId = pi.Id,
                                 ProductName = p.ProductName,
                                 Description = p.Description,
                                 UnitPrice = p.UnitPrice,
                                 AuthorName = a.AuthorName,
                                 GenreName = g.GenreName,
                                 PublisherName = pl.PublisherName,
                                 ImagePath = pi.ImagePath
                             };
                return expression == null ? await result.ToListAsync() : await result.Where(expression).ToListAsync();

            }
        }
    }
}
