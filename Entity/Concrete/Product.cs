using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entity.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public int GenreId { get; set; }
        public int ProductImageId { get; set; }
    }
}
