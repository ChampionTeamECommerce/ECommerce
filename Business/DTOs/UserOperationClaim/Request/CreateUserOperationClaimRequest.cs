﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.UserOperationClaim.Request
{
    public class CreateUserOperationClaimRequest
    {
        public Guid UserId { get; set; }
        public Guid OperationClaimId { get; set; }
    }
}
