using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    public class Medico : Persona
    {

        private int matricula;
        public int Matricula
        {
            get
            {
                return matricula;                
            }
            set
            {
                matricula = value;
            }
        }
    }
}
