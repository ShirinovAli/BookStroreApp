using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entity.Concrete
{
    public class Author :IEntity
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
