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
    public class GenreManager : IGenreService
    {
        private IGenreDal _genreDal;

        public GenreManager(IGenreDal genreDal)
        {
            _genreDal = genreDal;
        }
        public async Task<IResult> AddAsync(Genre entity)
        {
            await _genreDal.AddAsync(entity);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> UpdateAsync(Genre entity)
        {
            await _genreDal.UpdateAsync(entity);
            return new SuccessResult(Messages.Updated);
        }

        public async Task<IResult> DeleteAsync(Genre entity)
        {
            await _genreDal.DeleteAsync(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public async Task<IDataResult<Genre>> GetAsyncById(int id)
        {
            return new SuccessDataResult<Genre>(await _genreDal.GetAsync(g => g.GenreId == id));
        }

        public async Task<IDataResult<List<Genre>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Genre>>(await _genreDal.GetAllAsync());
        }
    }
}
