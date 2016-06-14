﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    public class Clinica : IClinica
    {
        private IList<Paciente> ListaPacientes;
        private IList<Medico> ListaMedicos;
        private IList<Atencion> ListaAtenciones;

        //Constructor de la clase Clinica
        public Clinica()
        {
            //Inicializo las listas //Paciente // Medico // Atencion
            // Listas necesarias para mantener en memoria los datos.
            this.ListaPacientes = new List<Paciente>();
            this.ListaMedicos = new List<Medico>();
            this.ListaAtenciones = new List<Atencion>();
        }

        //Obtiene la coleccion de atenciones.
        public IEnumerable<Atencion> ObtenerAtenciones()
        {
            return this.ListaAtenciones;
        }

        //Obtiene la coleccion de medicos.
        public IEnumerable<Medico> ObtenerMedicos()
        {
            return this.ListaMedicos;
        }

        //Obtiene la coleccion de pacientes.
        public IEnumerable<Paciente> ObtenerPacientes()
        {
            return this.ListaPacientes;
        }

        //Agrega Medico a la lista de medicos
        public void AgregarMedico(Medico medico)
        {
           this.ListaMedicos.Add(medico);
        }

        //Agrega paciente a la lista de paciente
        public void AgregarPaciente(Paciente Paciente)
        {
            this.ListaPacientes.Add(Paciente);
        }

        //Agrega atenciones a la lista de atecion
        public void AgregarAtencion(Atencion Atencion)
        {
            this.ListaAtenciones.Add(Atencion);
        }
    }
}
