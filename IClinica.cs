using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    public interface IClinica
    {

        void AgregarMedico(IMC.Medico medico);

        void AgregarPaciente(IMC.Paciente Paciente);

        List<IMC.Atencion> ObtenerAtenciones();

        List<IMC.Medico> ObtenerMedicos();

        List<IMC.Paciente> ObtenerPacientes();

        void AgregarAtencion(IMC.Atencion Atencion);
    }
}
