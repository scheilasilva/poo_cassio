namespace Aula06Tde
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Veiculo Carro = new Carro();
            Carro.Modelo = "golf";
            Carro.Acelerar();

            Veiculo moto = new Carro.Moto();
            moto.Modelo = "Yamaha";
            moto.Acelerar();
        }
    }
}