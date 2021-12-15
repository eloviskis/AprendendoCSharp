using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executanto o Projeto 5 - Caracteres e Textos");

            //character

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) 80;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia "+2020;
            string cursosProgramacao = 
@"-.NET 
- Java 
- Javascript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);


            string saudacao = "Olá, meu nome é ";
            string nome = "Rômulo ";
            string continuacao = "e minha idade é ";
            int idade = 100;
            Console.WriteLine(saudacao + nome + continuacao + idade);





            Console.ReadLine();


        }


    }
}
