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

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }
        public async Task<IResult> AddAsync(Author entity)
        {
            await _authorDal.AddAsync(entity);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> UpdateAsync(Author entity)
        {
            await _authorDal.UpdateAsync(entity);
            return new SuccessResult(Messages.Updated);
        }

        public async Task<IResult> DeleteAsync(Author entity)
        {
            await _authorDal.DeleteAsync(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public async Task<IDataResult<Author>> GetAsyncById(int id)
        {
            return new SuccessDataResult<Author>(await _authorDal.GetAsync(a => a.AuthorId == id));
        }

        public async Task<IDataResult<List<Author>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Author>>(await _authorDal.GetAllAsync());
        }
    }
}
