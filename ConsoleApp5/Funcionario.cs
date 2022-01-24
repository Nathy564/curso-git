using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
     class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem;
        }
        
    }
       

}
