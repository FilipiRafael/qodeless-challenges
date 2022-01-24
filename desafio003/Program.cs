using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_003
{

    public class Aluno
    {
        public string Nome { get; set; }
        public int Nota { get; set; }
        public override string ToString()
        {
            return "Nome: " + this.Nome + " | Nota: " + this.Nota;
        }
    }

    class Desafio003
    {
        static void Main(string[] args)
        {

            int alunosQuantidade;

            Console.WriteLine("Olá, digite a quantidade de alunos em sua sala: ");
            alunosQuantidade = Int32.Parse(Console.ReadLine());

            List<Aluno> listaAlunos = new List<Aluno>();


            for (int i = 0; i < alunosQuantidade; i++)
            {
                var aluno = new Aluno();
                Console.WriteLine("Digite o nome do aluno(a): ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite a nota do(a) " + aluno.Nome + ": ");
                aluno.Nota = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                listaAlunos.Add(aluno);
            }

            Aluno alunoMaiorNota = new Aluno();
            alunoMaiorNota.Nota = 0;
            foreach (Aluno aluno in listaAlunos)
            {
                if (aluno.Nota > alunoMaiorNota.Nota)
                {
                    alunoMaiorNota = aluno;
                }
                Console.WriteLine(aluno.ToString());
            }

            Console.WriteLine("========= MAIOR NOTA ========");
            Console.WriteLine("O melhor aluno foi: ");
            Console.WriteLine(alunoMaiorNota.ToString());
            Console.ReadLine();

        }
    }
}