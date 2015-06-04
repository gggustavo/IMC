using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    public abstract class Paciente : Persona
    {    
        public abstract string CalcularIMC(float peso, float altura);        
    }
}
