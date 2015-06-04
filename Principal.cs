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
        private Clinica clinica = new Clinica();

        public Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarMedico medico = new GestionarMedico(clinica);
            medico.Show();
        }

        private void agregarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarPacientes pacientes = new GestionarPacientes(clinica);
            pacientes.Show();
        }

        private void agregarAtencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarAtencion atencion = new GestionarAtencion(clinica);
            atencion.Show();
        }
    }
}
