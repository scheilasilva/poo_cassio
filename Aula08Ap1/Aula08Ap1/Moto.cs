namespace Aula08Ap1
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

//base chama os parametros da classe pai 
        public Moto(string marca, string modelo, string placa, int cilindrada) : base(marca, modelo, placa)
        {
            this.Cilindrada = cilindrada;
        }
//sobreescrevo a classe 
        public override void ImprimirDados()
        {
            Console.WriteLine($"{GetType().Name} - Marca: {Marca}, Modelo: {Modelo}, Placa: {Placa}, Cilindrada: {Cilindrada}");
        }

    }
}