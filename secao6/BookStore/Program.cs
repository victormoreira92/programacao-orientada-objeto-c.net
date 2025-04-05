using System.Globalization;
using BookStore.entities;
internal class Program
{
  static List<Book> books = new List<Book>();
  private static void Main(string[] args)
  {
    books.Add(new Book("Crime e Castigo", 1895,"Dostoevski", 54.12, 15));
    MostrarOpcoes(books);
  }

  private static void MostrarOpcoes(List<Book> books)
  {
    System.Console.WriteLine("=====MENU=====");
    System.Console.WriteLine("1. Cadastrar Produto");
    System.Console.WriteLine("2. Listar Produtos");
    System.Console.WriteLine("3. Calcular Valor Total do Estoque");
    System.Console.WriteLine("4. Sair");

    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
      case 1:
        CadastrarBook(books);
        break;

      case 2:
        ListarBook(books);
        break;

      case 3:
        CalcularValorTotal(books);
        break;
      case 4:
        return; // Sai do programa
      
      default:
        Console.WriteLine("Opção inválida!");
        break;

    }
    MostrarOpcoes(books);
  }

  private static void CalcularValorTotal(List<Book> books)
  {
    double Total = books.Sum(book => book.ValueTotalInStock());
    System.Console.WriteLine($"Total no estoque: {Total:F2}");
  }

  private static void ListarBook(List<Book> books)
  {
    books.ForEach(delegate(Book book){
      System.Console.WriteLine(book);
    });
  }

  private static void CadastrarBook(List<Book> books)
  {
    System.Console.Write("Digite a quantidade de livros a serem cadastrados: ");
    int qnt = int.Parse(Console.ReadLine());
    for (int i = 0; i < qnt; i++)
    {
      System.Console.WriteLine($"Digite dados do {i + 1} livro");
      System.Console.Write("Titulo do Livro: ");
      string title = Console.ReadLine();
      System.Console.Write("Ano de Lançamento: ");
      int yearRelease = int.Parse(Console.ReadLine());
      System.Console.Write("Nome do Autor: ");
      string author = Console.ReadLine();
      System.Console.WriteLine("O preço do livro: ");
      double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      System.Console.WriteLine("Quantidade de livros: ");
      int quantity = int.Parse(Console.ReadLine());

      books.Add(new Book(title, yearRelease, author, price, quantity));
    }
  }
}




