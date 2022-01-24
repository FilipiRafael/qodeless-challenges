using System;

namespace Desafio_002
{
    class Program
    {
        static void Main(string[] args)
        {

            // Cadastro de dados gerais em aplicação web

            string nome;
            string sobrenome;
            int idade;
            string sexo;
            string mensagem;

            Console.WriteLine(mensagem = "Olá, agora iremos iniciar o seu cadastro. Primeiro informe seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine(mensagem = "Certo " + nome + ", agora informe seu sobrenome.");
            sobrenome = Console.ReadLine();

            Console.Clear();


            Console.WriteLine("Anotado. " + nome + " " + sobrenome + ", agora precisamos saber a sua idade.");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (idade < 20)
            {
                Console.WriteLine("Então você tem " + idade + " anos, agora precisamos saber o seu sexo. Presione ENTER para continar.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Então você tem " + idade + " anos. Agora precisamos saber o seu sexo. Presione ENTER para continar.");
                Console.ReadLine();
            }


            Console.Clear();

            Console.WriteLine("Você se identifica como, MASCULINO, FEMININO OU OUTRO? (Digite dessa maneira)");
            sexo = Console.ReadLine();

            // Tratamento do input para lowerCase e UpperCase
            
            if (sexo.ToLower() == "feminino" || sexo.ToUpper() == "FEMININO")
            {
                Console.WriteLine("Então você se idenfica sendo do sexo FEMININO, precione ENTER, para ter a visão geral da sua ficha.");
                Console.ReadLine();
            }
            else if (sexo.ToLower() == "masculino" || sexo.ToUpper() == "MASCULINO")
            {
                Console.WriteLine("Então você se idenfica sendo do sexo MASCULINO, precione ENTER, para ter a visão geral da sua ficha.");
                Console.ReadLine();
            }
            else if (sexo.ToLower() == "outro" || sexo.ToUpper() == "OUTRO")
            {
                Console.WriteLine("Então você se idenfica sendo como OUTRO, precione ENTER, para ter a visão geral da sua ficha.");
                Console.ReadLine();
            }

            // O código estava enviando diretamente para esta última excessão, por conta do uso incorreto dos métodos LowerCase e UpperCase. Agora está corrigido.

            else
            {
                Console.WriteLine("Você declarou um valor inválido. Mais tarde você poderá editar a sua ficha, pressione ENTER para ter a visão geral da sua ficha.");
                Console.ReadLine();
            }


            Console.Clear();
            Console.WriteLine("Tudo pronto " + nome + ", aqui está sua ficha de cadastro");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sobrenome: " + sobrenome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Sexo: " + sexo);

            Console.ReadLine();
        }
    }
}