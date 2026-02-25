using System;

namespace Aula01Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ConcatenarPalavras();
           VerificarAulaEtec();
           CalcularMedia();
        }




        //Antes do fechamento da chave da classe

        public static void ConcatenarPalavras()
        {

            Console.WriteLine("Hello World!");

            Console.WriteLine("Digite seu nome");
            string nomeCompleto = Console.ReadLine();

            string frase1 = $"Ola {nomeCompleto}, hoje é  {DateTime.Now}";
            Console.WriteLine(frase1);
            Console.WriteLine("=======================");

            Console.WriteLine("Quanto custa em dolar em reais");
            decimal valorDolarReais = decimal.Parse (Console.ReadLine());
            string frase2 = string.Format("Dolar {0:c} em {1:dd/mm/yyyy}", valorDolarReais, DateTime.Now);
            Console.WriteLine(frase2);
            Console.WriteLine("=======================");

            string cabecalho = string.Format("{0:dddd}, {0:dd}, {0:MMMM} de {0:yy} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho);

            Console.ReadKey();

        }


        public static void VerificarAulaEtec()
        {
            Console.WriteLine("Digite a Data");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if(data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)

            {
                Console.WriteLine("final de semana! Hoje não tem aula! Revisarei exercicios.");
            }
            else
            {
                Console.WriteLine("Dia da semana! Bora para Etec!");
            }

        }

        public static void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A media é {media}");

            if (media >=7)
            Console.WriteLine("aprovado!");

            else if (media < 7 && media >= 4 )

            Console.WriteLine("recuperação");
            else 
            Console.WriteLine("reprovado");




        }




    
    }
}