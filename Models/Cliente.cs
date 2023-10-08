using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apirestcsharp.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string correo { get; set; }

    }
}