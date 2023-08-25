namespace tp1Java_cSharp
{
    public class MetodoTest
    {
        public static void Main(string[] args)
        {
            CalculadoraDeMedias calc = new CalculadoraDeMedias();
            int qtdAlunos;
            double nota, maiorNota = double.MinValue, somaNotas = 0.0;
            string nome, nomeMaiorNota = "";

            Console.Write("Quantos alunos deseja inserir? ");
            qtdAlunos = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.Write($"Digite o nome do {i + 1}(o) aluno(a): ");
                nome = Console.ReadLine();

                Console.Write($"Digite a nota do {i + 1}(o) aluno(a): ");
                nota = double.Parse(Console.ReadLine());

                if (nota > maiorNota)
                {
                    maiorNota = nota;
                    nomeMaiorNota = nome;
                }
                else if (nota == maiorNota)
                {
                    nomeMaiorNota = nome.CompareTo(nomeMaiorNota) < 0 ? nome : nomeMaiorNota;
                }

                somaNotas += nota;
            }

            Console.WriteLine($"A média da turma é: {calc.CalcularMediaAritmetica(somaNotas, qtdAlunos):F2}");
            Console.WriteLine($"A maior nota da turma é: {maiorNota}, do(a) aluno(a) {nomeMaiorNota}");

            Console.ReadKey();
        }
    }
}
