namespace Aula08Ap1
{
    public abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }

        public Veiculo(string marca, string modelo, string placa)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
        }

        public virtual void ImprimirDados()
        {
            Console.WriteLine($" - Marca: {Marca}, Modelo: {Modelo}, Placa: {Placa}");
        }

    }
}

