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
            return "Nome: " + this.Nome + "    NOTA: " + this.Nota;
        }
    }

    class Desafio003
    {
        static void Main(string[] args)
        {

            int alunosQTD;

            Console.WriteLine("Olá, para criar a sua tabela, informe quantos alunos tem em sua sala.");
            alunosQTD = Int32.Parse(Console.ReadLine());

            List<Aluno> listaAlunos = new List<Aluno>();


            for (int i = 0; i < alunosQTD; i++)
            {
                var aluno = new Aluno();
                Console.WriteLine("Digite o nome do aluno: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite a nota do aluno: ");
                aluno.Nota = Int32.Parse(Console.ReadLine());

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

            Console.WriteLine("O aluno com a maior nota é: ");
            Console.WriteLine(alunoMaiorNota.ToString());
            Console.ReadLine();

        }
    }
}