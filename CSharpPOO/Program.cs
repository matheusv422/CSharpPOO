using System;
using System.Globalization;
namespace CSharpPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno al = new Aluno();
            
            Console.Write("Nome do aluno: ");
            al.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            al.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(al);

            if (al.NotaFinal()< 60.00)
            {
                double diferenca = 60.00 - al.NotaFinal();
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "+ diferenca.ToString("F2",
                    CultureInfo.InvariantCulture)+ " PONTOS");
            }
            else
            {
                Console.WriteLine("APROVADO");
            }

        }
    }
}
