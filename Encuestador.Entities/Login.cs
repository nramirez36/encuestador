﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestador.Entities
{
    public class Login
    {
        public int IdEncuestador { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
