using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turma
{
    internal class Aluno
    {
        private string v1;
        private string v2;
        private int v3;

        public string Nome { get; set; }
        private string CPF { get; set; }
        protected string DtNascimento { get; set; }
        private int Faltas { get; set; }
        private double? Nota1 { get; set; }
        private double? Nota2 { get; set; }
        private double? Recuperacao { get; set; }

        public Aluno(string nome, string cPF, string dtNascimento, int faltas, double? nota1, double? nota2, double? recuperacao)
        {


            this.Nome = nome;
            this.CPF = cPF;
            this.DtNascimento = dtNascimento;
            this.Faltas = faltas;
            this.Nota1 = nota1 ?? throw new ArgumentNullException(nameof(nota1));
            this.Nota2 = nota2 ?? throw new ArgumentNullException(nameof(nota2));
            this.Recuperacao = recuperacao ?? throw new ArgumentNullException(nameof(recuperacao));
        }


        public void Faltou(int qtdFaltas) => Faltas += qtdFaltas;

        public void GetFaltas() => Console.WriteLine($"Total faltas: {Faltas}");

        public void SetNota(double nota1, double nota2)
        {
            this.Nota1 = nota1;
            this.Nota2 = nota2;

            Console.WriteLine(nota1 + ", " + nota2);

        }

        public void GetMedia()
        {
            Console.WriteLine($"Media: {(Nota1 + Nota2) / 2}");
        }

        public void SetRec(double rec)
        {
            this.Recuperacao = rec;
        }

        public void FoiAprovado()
        { 
            if((Nota1 + Nota2)/2 > 70f || Recuperacao > 70) 
            {
                Console.WriteLine("Aprovado");
            }
            else 
            { 
                Console.WriteLine("Reprovado"); 
            }
        }
    }
}
