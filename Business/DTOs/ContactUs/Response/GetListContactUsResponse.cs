using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.ContactUs.Response
{
    public class GetListContactUsResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ContactSubjectId { get; set; }
    }
}
