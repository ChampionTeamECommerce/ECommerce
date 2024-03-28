using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category:Entity<Guid>
    {
        public string Name { get; set; }


        //public virtual ICollection<Category> SubCategory { get; set; }
        //public virtual Category ParentCategory { get; set; }
        //public virtual ICollection<Course> Courses { get; set; }
        //public virtual ICollection<SynchronLessonDetail> SynchronLessonDetails { get; set; }
        //public virtual ICollection<AsyncLessonDetail> AsyncLessonDetails { get; set; }

    }
}
