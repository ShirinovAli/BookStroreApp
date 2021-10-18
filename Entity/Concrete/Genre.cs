using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entity.Concrete
{
    public class Genre :IEntity
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
    }
}
