using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    public class Atencion
    {
        private DateTime fecha;
        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }

        private Medico medico;
        public Medico Medico
        {
            get
            {
                return medico;
            }
            set
            {
                medico = value;
            }
        }

        private Paciente paciente;
        public Paciente Paciente
        {
            get
            {
                return paciente;
            }
            set
            {
                paciente = value;
            }
        }

        private float peso;
        public float Peso
        {
            get
            {
                return peso;
            }
            set
            {
                peso = value;
            }
        }

        private float estatura;
        public float Estatura
        {
            get
            {
                return estatura;
            }
            set
            {
                estatura = value;
            }
        }

        public string IMC { get; set; }
    }
}
