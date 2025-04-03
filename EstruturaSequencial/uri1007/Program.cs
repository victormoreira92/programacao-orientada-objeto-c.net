int a = 0, b = 0, c = 0, d = 0;
System.Console.WriteLine("Digite a os quatro numeros: ");

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
d = int.Parse(Console.ReadLine());

System.Console.WriteLine($"{(a * b - c * d)}");