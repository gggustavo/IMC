using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public int Dni { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
    }
}
