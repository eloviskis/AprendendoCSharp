using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4");

            double salario;
            salario = 1200.50;

            //O int é um tipo de variável que suporta valoress até 32 bits
            int salarioEmInteiro;
            salarioEmInteiro =(int) salario;
            
            Console.WriteLine(salarioEmInteiro);

            //O long é uma variável de 64 bits
            long idade;
            idade = 26000000000000000;
            Console.WriteLine(idade);

            //o short é um tipo de variável de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);


            Console.ReadLine();
        }
    }
}
