﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class EmployeeMV
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public string Version
        {
            get
            {
                return "Media Versoin V1";
            }
        }

    }
}
