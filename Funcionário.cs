// Para todos os funcionários a academia precisa cadastrar seus dados pessoais, como Nome, Endereço, Telefone, 
// Carteira de Trabalho e Salário. Especificamente se o funcionário for um professor é necessário armazenar 
// também a sua Especialização. 

// Crie um programa em C#.NET que crie uma classe chamada Funcionário e outra chamada de Professor, herdeira 
// da classe Funcionário, todas elas com os atributos definidos. Crie construtores nas classes que inicializem cada 
// atributo.

using System;

class Funcionário
    {

        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
        private string _Endereço;

        public string Endereço
        {
            get { return _Endereço; }
            set { _Endereço = value; }
        }

        private string _Telefone;

        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        private string _Depto;

        public string Depto
        {
            get { return _Depto; }
            set { _Depto = value; }
        }

        private double _Salário;

        public double Salário
        {
            get { return _Salário; }
            set
            {
                if (value < 0)
                    _Salário = 0;
            }
        }


        public void LerDados()
        {
            Console.Write("Nome do Funcionário.....: ");
            _Nome = Console.ReadLine();
    
            Console.Write("Endereço do Funcionário.....: ");
            _Endereço = Console.ReadLine();

            Console.Write("Telefone do Funcionário.....: ");
            _Telefone = Console.ReadLine();

            Console.Write("Especialidade............: ");
            _Depto = Console.ReadLine();

            Console.Write("Salário (R$)............: ");
            _Salário = double.Parse(Console.ReadLine());


        }
    }
