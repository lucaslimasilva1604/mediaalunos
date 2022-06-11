using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine(" Escola Santa Paciencia");
            Console.WriteLine("------------------------");

            Console.Write("Quantos alunos a turma tem? ");
            int totalAluno = int.Parse(Console.ReadLine());

            double melhorNota = 0;
            string melhorAluno = "";

            for (int i = 1; i <= totalAluno; i++)
            {
                Console.WriteLine("---------------");
                Console.WriteLine($"ALUNO {i}");
                Console.Write("Nome do aluno: ");
                string nomeDoAluno = Console.ReadLine();
                Console.Write($"Nota de {nomeDoAluno}: ");
                double notaDoAluno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (notaDoAluno > melhorNota)
                {
                    melhorNota = notaDoAluno;
                    melhorAluno = nomeDoAluno;
                }
            }

            Console.WriteLine("------------------------");
            Console.WriteLine($"O melhor aproveitamento foi de {melhorAluno} com a nota {melhorNota.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
        }
    }
}
