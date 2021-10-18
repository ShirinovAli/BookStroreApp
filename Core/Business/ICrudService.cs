using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;
using Core.Utilities.Results.Abstract;

namespace Core.Business
{
    public interface ICrudService<T> 
        where T:class,IEntity,new()
    {
        Task<IResult> AddAsync(T entity);
        Task<IResult> UpdateAsync(T entity);
        Task<IResult> DeleteAsync(T entity);
        Task<IDataResult<T>> GetAsyncById(int id);
        Task<IDataResult<List<T>>> GetAllAsync();
    }
}
