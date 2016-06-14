using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    public interface IClinica
    {

        void AgregarMedico(Medico medico);

        void AgregarPaciente(Paciente Paciente);

        void AgregarAtencion(Atencion Atencion);

        IEnumerable<Atencion> ObtenerAtenciones();

        IEnumerable<Medico> ObtenerMedicos();

        IEnumerable<Paciente> ObtenerPacientes();

        
    }
}
