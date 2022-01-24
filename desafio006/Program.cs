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
            // Em notas acumuladas, podería refatorar para mostrar apenas a nota individual de cada aluno, apenas no final a somatória
            return "Nome: " + this.Nome + " | Idade: " + this.Idade + " | Notas Acumuladas: " + this.Nota;
        }
    }

    class Desafio004
    {
        static void Main(string[] args)
        {

            int alunosQuantidade = 3;
            Aluno alunos = new Aluno();
            List<Aluno> listaAlunos = new List<Aluno>();

            for (int i = 0; i < alunosQuantidade; i++)
            {
                var aluno = new Aluno();
                Console.WriteLine("Digite o nome do(a) aluno: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite a idade de " + aluno.Nome + ": ");
                aluno.Idade = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota de " + aluno.Nome + ": ");
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

            Console.WriteLine("");
            Console.WriteLine("========== SOMA ==========");
            Console.WriteLine("");
            Console.WriteLine("A soma das três notas resulta em: " + alunosSoma.Nota + ".");
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome;idade;nota");
            alunos.ForEach(x => sb.AppendLine($"{alunos.Nome};{alunos.Idade};{alunos.Nota}"));
            var filepath = @"/home/filipirafael/Documents/alunos.csv";
            Console.WriteLine("Salvar arquivo");
            filepath.WriteAllText(filepath,sb.ToString());
            Console.ReadKey();
        }
    }
}