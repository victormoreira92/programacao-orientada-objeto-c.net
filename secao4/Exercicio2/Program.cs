using Exercicio2.entities;
internal class Program
{
  private static void Main(string[] args)
  {
    List<Funcionario> funcionarios= new List<Funcionario>();  
    for (int i = 0; i < 3; i++)
    {
      System.Console.WriteLine("Digite os dados dos funcionários:");
      string nome = Console.ReadLine();
      decimal salario = decimal.Parse(Console.ReadLine());

      funcionarios.Add(new Funcionario(nome, salario));

    }
    decimal mediaSalarial = funcionarios.Average(p => p.Salario);
    Console.WriteLine($"Média salarial: R$ {mediaSalarial:F2}");
  }
}