using System.Runtime.InteropServices;
using Exercicio1.models;
internal class Program
{
  private static void Main(string[] args)
  {
    List<Pessoa> listaDePessoas = new List<Pessoa>();
    for (int i = 0; i < 3; i++){
      Console.WriteLine($"Digite os dados da {i + 1}ª pessoa");
      System.Console.Write("Nome: "); 
      string nome = Console.ReadLine();
      System.Console.Write("Idade: "); 
      int idade = int.Parse(Console.ReadLine());
      listaDePessoas.Add(new Pessoa{Nome = nome ,Idade = idade} );
    }
    System.Console.WriteLine("A pessoa mais velha é "+listaDePessoas.OrderByDescending(p => p.Idade).FirstOrDefault());
  }
}