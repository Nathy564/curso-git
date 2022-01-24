using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            func.Nome = "Joao Silva";
            func.SalarioBruto = 6000;
            func.Imposto = 1000;

            Console.WriteLine($"Funcionário: {func.Nome}, R${func.SalarioLiquido():N2}");
            Console.WriteLine("Digite  a porcentagem para aumentar o salário:");
            double porcentagem = double.Parse(Console.ReadLine()) / 100;
            func.AumentarSalario(porcentagem);
            Console.WriteLine($"Dados atualizados: {func.Nome}, R${func.SalarioLiquido():N2}");
            Console.WriteLine("alo galera de cowboy");

        }
    }
}
