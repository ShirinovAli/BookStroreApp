using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entity.Dtos
{
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public int ProductImageId { get; set; }
        public string ProductName { get; set; }
        public string GenreName { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImagePath { get; set; }
    }
}
