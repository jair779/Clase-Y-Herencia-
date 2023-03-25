using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    internal class Registro : Usuario
    {
        public Registro() { }   
        public string nombre { get; set; }  
        public string detalles { get; set; }
    }
}
