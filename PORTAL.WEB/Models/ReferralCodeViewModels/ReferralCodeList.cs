﻿using PORTAL.WEB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PORTAL.WEB.Models.ReferralCodeViewModels
{
    public class ReferralCodeList
    {
        public IEnumerable<ReferralCodeModel> Records { get; set; }
        public IUserHandler UserHandler { get; set; }
    }
}
