using Core.Entity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Clothes:Entity<Guid>
    {
        public string Name  { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public int StockAmount { get; set; }
        public double ProductPrice { get; set; }
       
        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }

        public virtual Category Category { get; set;}
        public virtual Brand Brand { get; set;}



        //ürün kodu yapılacakmı tekrar bak  

      //RenkID INT,
      //CinsiyetID INT,
    
    //ResimURL VARCHAR(255),
    }
}
