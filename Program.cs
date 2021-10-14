using System;
using System.Collections.Generic;

namespace Academia
{
    class Program
    {
        static void Main(string[] args)
        {
               List<Funcionário> Cadastro = new List<Funcionário>();

            do
            {
                Console.Clear();

                Funcionário Func = new Funcionário();

                Func.LerDados();

                Cadastro.Add(Func);

                Console.Write("\nDeseja cadastrar outro funcionário? (ESC cancela...");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Clear();

            string Departamento;

            Console.Write("Listar funcionários de qual departamento? ");
            Departamento = Console.ReadLine();

            foreach (Funcionário F in Cadastro)
            {
                if (F.Depto == Departamento)
                {
                    Console.WriteLine("\n{0} ", F.Nome);
                    // Console.WriteLine("Admissão: {0} de {1} de {2}",
                    //                    F.Admissão.Dia,
                    //                    F.Admissão.Mês,
                    //                    F.Admissão.Ano);
                    Console.WriteLine("Salário: R$ {0:F2}", F.Salário);
                }
            }

            Console.ReadKey();
        }
    }
}


// No programa principal uma estrutura de dados capaz de armazenar até 100 funcionários que trabalham em cada 
// uma das duas áreas descritas (Administração e Professor). O programa deverá também listar todos os 
// funcionários cadastrados. 
