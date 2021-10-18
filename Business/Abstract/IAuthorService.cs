using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IAuthorService : ICrudService<Author>
    {
    }
}
