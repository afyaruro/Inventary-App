﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Presentacion
{
    public static class ConfigConnection
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
    }
}
