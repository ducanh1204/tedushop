﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeAttendency.WebApp.Models
{
    public class LoginRequestModel
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string grant_type { get; set; } = "password";
    }
}