using Dominio;

namespace Tests;

public class TrianguloTests
{
    // [Fact]
    // public void EsTriangulo_DebeRetornarVerdadero()
    // {
    //     //arrange
    //     var triangulo = new Triangulo(5, 3, 5);

    //     //act
    //     bool resultado = triangulo.EsTriangulo();

    //     //assert
    //     Assert.Equal(resultado, true);
    // }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(2, 5, 3)]
    [InlineData(5, 3, 2)]
    [InlineData(5, 3, 0)]
    [InlineData(2, 4, 10)]
    [InlineData(-3, -5, -4)]
    public void EsTriangulo_DebeRetornarFalso(int a, int b, int c)
    {
        //arrange
        var triangulo = new Triangulo(a, b, c);

        //act
        bool resultado = triangulo.EsTriangulo();

        //assert
        Assert.Equal(false, resultado);
    }

    // [Fact]
    // public void EsTriangulo_DebeRetornarFalso()
    // {
    //     //arrange
    //     var triangulo = new Triangulo(1, 1, 2);

    //     //act
    //     bool resultado = triangulo.EsTriangulo();

    //     //assert
    //     Assert.NotEqual(res1ultado, true);
    //     //Assert.Equal(resultado, false);
    // }

    [Theory]
    [InlineData(2, 2, 2)]
    public void TrianguloEsEquilatero_DebeRetornarVerdadero(int a, int b, int c)
    {
        var triangulo = new Triangulo(a, b, c);
        var resultado = triangulo.Tipo();
        Assert.Equal("Equilatero", resultado);
    }

    [Theory]
    [InlineData(2, 3, 4)]
    [InlineData(2, 4, 3)]
    [InlineData(3, 4, 2)]
    [InlineData(3, 2, 4)]
    [InlineData(4, 2, 3)]
    [InlineData(4, 3, 2)]
    public void TrianguloEsEscaleno_DebeRetornarVerdadero(int a, int b, int c)
    {
        var triangulo = new Triangulo(a, b, c);
        var resultado = triangulo.Tipo();
        Assert.Equal("Escaleno", resultado);
    }

    [Theory]
    [InlineData(4, 3, 3)]
    [InlineData(3, 4, 3)]
    [InlineData(3, 3, 4)]
    public void TrianguloEsIsosceles_DebeRetornarVerdadero(int a, int b, int c)
    {
        var triangulo = new Triangulo(a, b, c);
        var resultado = triangulo.Tipo();
        Assert.Equal("Isosceles", resultado);
    }
}