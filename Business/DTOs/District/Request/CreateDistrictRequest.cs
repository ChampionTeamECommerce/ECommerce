﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.District.Request
{
    public class CreateDistrictRequest
    {
        public string Name { get; set; }
        public Guid CityId { get; set; }

    }
}
