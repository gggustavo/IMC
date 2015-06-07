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
        IClinica clinica;

        public GestionarMedico()
        {
            InitializeComponent();

            clinica = container.GetContainer().GetInstance<IClinica>();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
   
            this.medicoBindingSource.DataSource = null;
            this.medicoBindingSource.DataSource = clinica.ObtenerMedicos();  

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            //TODO: resta validar campos ingresados por el usuario.
            try
            {
                Medico medico = new Medico() { 
                    Matricula = Convert.ToInt32(this.nromatricula.Text),
                    Nombre = this.nombre.Text,
                    Telefono = Convert.ToInt32(this.telefono.Text),
                    Email = this.email.Text,
                };

                clinica.AgregarMedico(medico);     
           
                this.medicoBindingSource.DataSource = null;
                this.medicoBindingSource.DataSource = clinica.ObtenerMedicos();
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
