namespace Dominio;

public class Triangulo
{
    public List<int> lados { get; set; }

    public Triangulo(int a, int b, int c)
    {
        lados = new List<int>();
        lados.Add(a);
        lados.Add(b);
        lados.Add(c);
    }

    public void Informar()
    {
        if (EsTriangulo())
            System.Console.WriteLine($"Tipo triangulo: {Tipo()}");
        else
            System.Console.WriteLine("Los lados ingresados no forman un triangulo");
    }

    public bool EsTriangulo() =>
        lados.OrderBy(x => x).Take(2).Sum() > lados.Max() && lados.Count == 3;

    public string Tipo()
    {
        if (lados.Where(x => x == lados.First()).Count() == 3)
            return "Equilatero";
        else
        {
            int repetido = lados.OrderBy(x => x).ToList()[1];
            if (lados.Where(x => x == repetido).Count() == 2)
                return "Isosceles";
            else
                return "Escaleno";
        }
    }
}
