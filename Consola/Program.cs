using Dominio;

Console.WriteLine("Ingrese un numero:");
int lado1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un numero:");
int lado2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un numero:");
int lado3 = Convert.ToInt32(Console.ReadLine());

var triangulo = new Triangulo(lado1, lado2, lado3);

triangulo.Informar();