class Program
{
    static void Main(string[] args)
    {
        Calculadora calcular  = new Calculadora();

        int resultadoSoma = calcular.somar(10,5);
        int resultadosubtracao = calcular.subtrair(10,5);

        Console.WriteLine("resultado da soma:{0}", resultadoSoma);
        Console.WriteLine("resultado da subtraca: {0}", resultadosubtracao);
         
    }
}