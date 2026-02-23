using System;

namespace TipoBasicos
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("====== Tipos Básicos =========");

      sbyte x = 100; // Sbyte vem do .NET caso system sai ele não funciona
      byte y = 100; // Byte não aceita numero negativo
      int z = 2000; 
      long l = 21245896345678L;
      char c = '\u3A79'; // char pode ser expresso com o codigo unicode
      float f = 2.5f;
      double d = 2.5;
      DayOfWeek days = new DayOfWeek();
      
      Object[] variaveis = [x, y, z, l, c, f, d];
      
      foreach (var item in variaveis)
      {
        Console.WriteLine($"O tipo {item} é do tipo {item.GetType().Name}");
      }

      foreach (var day in Enum.GetValues(typeof(DayOfWeek)))
      {
        Console.WriteLine($"O dia da semana é {day}");
      }
    }
  }
} 
