using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cliente
    {
        public string CedulaCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string CelularCliente { get; set; }

        public Cliente() { 
        
        }

        public Cliente(string cc, string nombre, string apellido, string celular) {

            this.CedulaCliente = cc;
            this.NombreCliente = nombre;
            this.ApellidoCliente = apellido;
            this.CelularCliente = celular;

        }

    }
}
