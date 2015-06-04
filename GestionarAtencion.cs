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
    public partial class GestionarAtencion : Form
    {
        private Clinica objclinica;
        public GestionarAtencion(Clinica clinica)
        {
            InitializeComponent();
            objclinica = clinica;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            this.medicoBindingSource.DataSource = null;
            this.medicoBindingSource.DataSource = objclinica.ObtenerMedicos();

            this.pacienteBindingSource.DataSource = null;
            this.pacienteBindingSource.DataSource = objclinica.ObtenerPacientes();

            this.atencionBindingSource.DataSource = null;            
            List<Atencion> listatencion = objclinica.ObtenerAtenciones();
            this.atencionBindingSource.DataSource = listatencion.Select(x => new DisplayAtencion() { NombrePaciente = x.Paciente.Nombre, Fecha = x.Fecha, Peso = x.Peso, IMC = x.IMC, Estatura = x.Estatura });
            
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Atencion atencion = new Atencion();
                atencion.Medico = (Medico)this.medicoBindingSource.CurrencyManager.Current;
                atencion.Paciente = (Paciente)this.pacienteBindingSource.CurrencyManager.Current;
                atencion.Peso = Convert.ToSingle(this.peso.Text);
                atencion.Estatura = float.Parse(this.altura.Text, System.Globalization.CultureInfo.InvariantCulture);
                atencion.Fecha = this.Nac.Value;
                atencion.IMC = atencion.Paciente.CalcularIMC(atencion.Peso, atencion.Estatura);

                objclinica.AgregarAtencion(atencion);

                this.atencionBindingSource.DataSource = null;
                List<Atencion> listatencion = objclinica.ObtenerAtenciones();
                this.atencionBindingSource.DataSource = listatencion.Select(x => new DisplayAtencion() { NombrePaciente = x.Paciente.Nombre, Fecha = x.Fecha, Peso = x.Peso, IMC = x.IMC, Estatura = x.Estatura });
                MessageBox.Show("Se agrego correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
            

        }


    }
}
