using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    public class Atencion
    {
        public DateTime Fecha { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public float Peso { get; set; }
        public float Estatura { get; set; }
        public string IMC { get; set; }
    }
}
