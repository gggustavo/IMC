using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    public abstract class Persona
    {
        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        private int telefono;
        public int Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }

        private int dni;
        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }

        private string domicilio;
        public string Domicilio
        {
            get
            {
                return domicilio;
            }
            set
            {
                domicilio = value;
            }
        }

        private DateTime fechanacimiento;
        public DateTime FechaNacimiento
        {
            get
            {
                return fechanacimiento;
            }
            set
            {
                fechanacimiento = value;
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
    }
}
