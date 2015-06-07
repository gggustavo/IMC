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
        IClinica clinica;
        public GestionarAtencion()
        {
            InitializeComponent();

            clinica = container.GetContainer().GetInstance<IClinica>();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.medicoBindingSource.DataSource = null;
            this.medicoBindingSource.DataSource = clinica.ObtenerMedicos();

            this.pacienteBindingSource.DataSource = null;
            this.pacienteBindingSource.DataSource = clinica.ObtenerPacientes();

            this.atencionBindingSource.DataSource = null;
            List<Atencion> listatencion = clinica.ObtenerAtenciones();
            this.atencionBindingSource.DataSource = listatencion.Select(x => new DisplayAtencion() { NombrePaciente = x.Paciente.Nombre,
                                                                                                     Fecha = x.Fecha, Peso = x.Peso,
                                                                                                     IMC = x.IMC, Estatura = x.Estatura });
            
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Atencion atencion = new Atencion() { 
                    Medico = (Medico)this.medicoBindingSource.CurrencyManager.Current,
                    Paciente = (Paciente)this.pacienteBindingSource.CurrencyManager.Current,
                    Peso = Convert.ToSingle(this.peso.Text),
                    Estatura = float.Parse(this.altura.Text, System.Globalization.CultureInfo.InvariantCulture),
                    Fecha = this.Nac.Value,
                };
         
                atencion.IMC = atencion.Paciente.CalcularIMC(atencion.Peso, atencion.Estatura);

                clinica.AgregarAtencion(atencion);

                this.atencionBindingSource.DataSource = null;
                List<Atencion> listatencion = clinica.ObtenerAtenciones();
                this.atencionBindingSource.DataSource = listatencion.Select(x => new DisplayAtencion() { NombrePaciente = x.Paciente.Nombre,
                                                                                                         Fecha = x.Fecha, Peso = x.Peso,
                                                                                                         IMC = x.IMC, Estatura = x.Estatura });

                MessageBox.Show("Se agrego correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }


    }
}
