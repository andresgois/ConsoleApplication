using System.ComponentModel;
using System;
using System.Globalization;

namespace ConsoleApplicationVSCode
{
    class Program
    {
        static void Main(String[] args)
        {
            //Hello();
            //Aula02();
            //Aula03();
            EntradaDadosEmCharp();

            /*
                SByte a = 124;
                System.Console.WriteLine("a: "+a);
                Console.WriteLine("What is your name? ");
                String name = Console.ReadLine();
                var currentDate = DateTime.Now;
                // NewLine -> representa uma quebra de linha.
                System.Console.WriteLine($"{Environment.NewLine} Hello, {name}, on {currentDate.Date}");
                System.Console.WriteLine($"{Environment.NewLine} Press any key to exit...");
                // Espera que uma tecla seja clicada para sair

                string nome = "Andre";
                SByte idade = 33;
                float salario = 2.1478F;
                Console.WriteLine($"Meu nome é {nome} de idade {idade}, cujo, salário é {salario:F2.CultureInfo.InvariantCulture}");

                Console.ReadKey(true);
            */
        }

        public static void Hello()
        {
            Console.WriteLine("Hello world 2");

        }
        public static void Aula02()
        {
            string produto1 = "Compoutador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.5;
            double preco3 = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");

            Console.WriteLine();

        }

        public static void Aula03(){
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.5;
            double preco3 = 53.234567;

            Console.WriteLine($"Registro: ${idade} anos de idade, código {codigo} e gênero: {genero}");
            
            Console.WriteLine();
            
            Console.WriteLine("Medida com oito casas decimais: "+preco3.ToString("F8"));
            Console.WriteLine("Arredondamento (Três casa decimais): "+preco3.ToString("F3"));
            Console.WriteLine("separador deciaml invariant culture: "+preco3.ToString("F3", CultureInfo.InvariantCulture));
        }
    
        public static void EntradaDadosEmCharp(){
            Console.WriteLine("Digite um número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o genero");
            char n2 = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número decimal");
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}