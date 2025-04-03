// Retornar o valor de numero vezes pi
double pi = 3.14159;
double valor_raio = double.Parse(Console.ReadLine());
System.Console.WriteLine(valor_raio);
double area = pi * Math.Pow(valor_raio, 2);

Console.WriteLine($"{area:F2}");

