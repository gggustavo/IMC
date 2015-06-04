using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    public class Mujer : Paciente
    {

        public override string CalcularIMC(float peso, float altura)
        {
            double imc = Math.Round(peso / (altura * altura));
            
            if (imc == 16)
            {
                return "Desnutrición";
            }
            if (imc >= 17 && imc <= 20)
            {
                return "Bajo Peso";
            }
            if (imc >= 21 && imc <= 24)
            {
                return "Normal";
            }
            if (imc >= 25 && imc <= 29)
            {
                return "Sobrepeso";
            }
            if (imc >= 30 && imc <= 34)
            {
                return "Obesidad";
            }
            if (imc >= 35 && imc <= 39)
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
