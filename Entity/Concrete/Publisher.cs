using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entity.Concrete
{
    public class Publisher :IEntity
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
    }
}
