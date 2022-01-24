using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_004
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Nota { get; set; }
        public override string ToString()
        {
            return "Nome: " + this.Nome + "    IDADE: " + this.Idade + "    NOTA: " + this.Nota;
        }
    }

    class Desafio004
    {
        static void Main(string[] args)
        {

            int alunosQTD = 3;
            Aluno alunos = new Aluno();
            List<Aluno> listaAlunos = new List<Aluno>();

            for (int i = 0; i < alunosQTD; i++)
            {
                var aluno = new Aluno();
                Console.WriteLine("Digite o nome do aluno: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite a idade do aluno: ");
                aluno.Idade = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota do aluno: ");
                aluno.Nota = Int32.Parse(Console.ReadLine());

                listaAlunos.Add(aluno);
            }

            Aluno alunosSoma = new Aluno();
            alunosSoma.Nota = 0;
            foreach (Aluno aluno in listaAlunos)
            {
                if (Convert.ToBoolean(aluno.Nota += alunosSoma.Nota))
                {
                    alunosSoma = aluno;
                }
                Console.WriteLine(aluno);
            }

            Console.WriteLine("A soma das notas dos três alunos é: ");
            Console.WriteLine(alunosSoma.Nota);
            Console.ReadLine();

        }
    }
}