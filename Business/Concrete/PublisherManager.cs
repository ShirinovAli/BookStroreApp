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
    public class PublisherManager : IPublisherService
    {
        private IPublisherDal _publisherDal;

        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }
        public async Task<IResult> AddAsync(Publisher entity)
        {
            await _publisherDal.AddAsync(entity);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> UpdateAsync(Publisher entity)
        {
            await _publisherDal.UpdateAsync(entity);
            return new SuccessResult(Messages.Updated);
        }

        public async Task<IResult> DeleteAsync(Publisher entity)
        {
            await _publisherDal.DeleteAsync(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public async Task<IDataResult<Publisher>> GetAsyncById(int id)
        {
            return new SuccessDataResult<Publisher>(await _publisherDal.GetAsync(pl => pl.PublisherId == id));
        }

        public async Task<IDataResult<List<Publisher>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Publisher>>(await _publisherDal.GetAllAsync());
        }
    }
}
