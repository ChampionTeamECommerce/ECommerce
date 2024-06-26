﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CartItem:Entity<Guid>
    {

        public Guid? ProductId { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }

    }
}
