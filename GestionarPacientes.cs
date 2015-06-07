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
    public partial class GestionarPacientes : Form
    {
        IClinica clinica;

        public GestionarPacientes()
        {
            InitializeComponent();

            clinica = container.GetContainer().GetInstance<IClinica>();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.pacienteBindingSource.DataSource = null;
            this.pacienteBindingSource.DataSource = clinica.ObtenerPacientes();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: resta validar campos ingresados por el usuario.

                Paciente objpaciente = null;
                //HOMBRE
                if (sexo.SelectedItem.ToString().Contains("Hombre"))
                {
                    objpaciente = new Hombre();
                }

                //MUJER
                if (sexo.SelectedItem.ToString().Contains("Mujer"))
                {
                    objpaciente = new Mujer();
                }

                objpaciente.Nombre = this.nombre.Text;
                objpaciente.Dni = Convert.ToInt32(this.dni.Text);
                objpaciente.FechaNacimiento = Nac.Value;
                objpaciente.Domicilio = this.domicilio.Text;
                objpaciente.Telefono = Convert.ToInt32(this.telefono.Text);

                clinica.AgregarPaciente(objpaciente);

                this.pacienteBindingSource.DataSource = null;
                this.pacienteBindingSource.DataSource = clinica.ObtenerPacientes();

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
