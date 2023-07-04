using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Name { get; set; }
        public Cargo Cargo{ get; set; }
        public Empresa Empresa { get; set; }
    }
}
