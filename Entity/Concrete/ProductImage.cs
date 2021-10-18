using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entity.Concrete
{
    public class ProductImage : IEntity
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
