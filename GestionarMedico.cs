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
    public partial class GestionarMedico : Form
    {
        Clinica objclinica;

        public GestionarMedico(Clinica clinica)
        {
            InitializeComponent();
            objclinica = clinica;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.medicoBindingSource.DataSource = null;
            this.medicoBindingSource.DataSource = objclinica.ObtenerMedicos();  

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            //TODO: resta validar campos ingresados por el usuario.
            try
            {
                Medico medico = new Medico();
                medico.Matricula = Convert.ToInt32(this.nromatricula.Text);
                medico.Nombre = this.nombre.Text;
                medico.Telefono = Convert.ToInt32(this.telefono.Text);
                medico.Email = this.email.Text;
                objclinica.AgregarMedico(medico);                
                this.medicoBindingSource.DataSource = null;
                this.medicoBindingSource.DataSource = objclinica.ObtenerMedicos();
                MessageBox.Show("Se agrego correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }


       
    }
}
