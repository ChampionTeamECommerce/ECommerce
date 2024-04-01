﻿using Core.Entity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Entities.Concretes;

public class Product:Entity<Guid>
{
    public string Name  { get; set; }
    public string Description { get; set; }
    public int StockAmount { get; set; }
    public double ProductPrice { get; set; }
   
    public Guid CategoryId { get; set; }
    public Guid BrandId { get; set; }
    public Guid GenderId { get; set; }
    public Guid SizeId { get; set; }
    public Guid ColorId { get; set; }

    public virtual Gender Gender { get; set; }
    public virtual Category Category { get; set;}
    public virtual Brand Brand { get; set;}
    public virtual Size Size { get; set; }
    public virtual Color Color { get; set; }




    //ürün kodu yapılacakmı tekrar bak  

    //ResimURL VARCHAR(255) image ıd
}