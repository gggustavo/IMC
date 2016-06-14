using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMC
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();


            LoadDataDefault();

        }

        private void LoadDataDefault()
        {
            for (int i = 1; i < 6; i++)
            {
                var medico = new Medico()
                {
                    Matricula = i,
                    Nombre = "Medico " + i,
                    Telefono = 4645678,
                    Email = "medico@medico.com",
                };
                container.GetContainer().GetInstance<IClinica>().AgregarMedico(medico);
            }

            for (int i = 1; i < 6; i++)
            {
                var paciente = new Hombre()
                {
                    Dni = 45467890 + i,
                    Domicilio = "Domicilio hombre " + i,
                    Email = "hombre@paciente.com",
                    FechaNacimiento = DateTime.Parse("04/02/1980"),
                    Nombre = "hombre " + i,
                    Telefono = 56788900 + i,
                };
                container.GetContainer().GetInstance<IClinica>().AgregarPaciente(paciente);
            }

            for (int i = 1; i < 6; i++)
            {
                var paciente = new Mujer()
                {
                    Dni = 18467890 + i,
                    Domicilio = "Domicilio Mujer " + i,
                    Email = "mujer@paciente.com",
                    FechaNacimiento = DateTime.Parse("04/02/1980"),
                    Nombre = "Mujer " + i,
                    Telefono = 56788900 + i,
                };
                container.GetContainer().GetInstance<IClinica>().AgregarPaciente(paciente);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarMedico medico = new GestionarMedico();
            medico.ShowDialog(this);
        }

        private void agregarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarPacientes pacientes = new GestionarPacientes();
            pacientes.ShowDialog(this);
        }

        private void agregarAtencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarAtencion gestionarAtencion = new GestionarAtencion();
            gestionarAtencion.ShowDialog(this);
                 
        }
    }
}
