

// EXERCÍCIO COM CLASSES E OBJETOS UTILIZANDO CSHARP

// PROGRAMA QUE RECEBE NOTAS DE ALUNOS, FAZ UM RELATÓRIO E CALCULA A MEDIA FINAL
// ENTREGANDO UM RELATÓRIO

public class Aluno
{
    public string Nome { get; set; }
    public double[] Notas { get; set; }
    public double Media { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("VAMOS DESCOBRIR A SUA MÉDIA FINAL!");

        Aluno aluno = new Aluno();

        Console.WriteLine("QUAL O SEU NOME?");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("QUANTAS NOTAS VOCÊ VAI INFORMAR?");
        int qtd = int.Parse(Console.ReadLine());

        Console.WriteLine("Você irá digitar " + qtd + " notas !!!");

        aluno.Notas = new double[qtd];

        Console.WriteLine("DIGITE AS NOTAS NOS CAMPOS ABAIXO: ");
        for (int i = 0; i < qtd; i++)
        {
            Console.Write("NOTA " + (i + 1) + ": ");
            double nota = double.Parse(Console.ReadLine());
            aluno.Notas[i] = nota;
        }

        double soma = 0;
        for (int i = 0; i < aluno.Notas.Length; i++)
        {
            soma += aluno.Notas[i];
        }
        
        aluno.Media = soma / qtd;

        Console.WriteLine();
        Console.WriteLine("===== RELATÓRIO =====");
        Console.WriteLine("ALUNO: " + aluno.Nome);
        for (int i = 0; i < aluno.Notas.Length; i++)
        {
            Console.WriteLine("NOTA " + (i + 1) + ": " + aluno.Notas[i]);
        }
        Console.WriteLine("MÉDIA FINAL: " + aluno.Media);
        Console.WriteLine(aluno.Media >= 7 ? "APROVADO!" : "REPROVADO!");
    }
}
