using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    public class Hombre : Paciente
    {

        public override string CalcularIMC(float peso, float altura)
        {
            double imc = Math.Round(peso / (altura * altura));
            if (imc == 17)
            {
                return "Desnutrición";
            }
            if (imc >= 18 && imc <= 19)
            {
                return "Bajo Peso";
            }
            if (imc >= 21 && imc <= 25)
            {
                return "Normal";
            }
            if (imc >= 26 && imc <= 30)
            {
                return "Sobrepeso";
            }
            if (imc >= 31 && imc <= 35)
            {
                return "Obesidad";
            }
            if (imc >= 36 && imc <= 40)
            {
                return "Obesidad Marcada";
            }
            if (imc >= 40)
            {
                return "Obesidad Mórbida";
            }

            return string.Empty;
        }
    }
}
