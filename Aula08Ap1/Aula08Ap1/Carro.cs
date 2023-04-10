namespace Aula08Ap1
{
    public class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }

        public Carro(string marca, string modelo, string placa, int numeroPortas) : base(marca, modelo, placa)
        {
            this.NumeroPortas = numeroPortas;
        }

        public override void ImprimirDados()
        {
            Console.WriteLine($"{GetType().Name} - Marca: {Marca}, Modelo: {Modelo}, Placa: {Placa}, Numero de portas: {NumeroPortas}");
        }
    }
}