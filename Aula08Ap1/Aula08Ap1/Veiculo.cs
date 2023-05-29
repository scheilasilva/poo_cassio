namespace Aula08Ap1
{
    //classe veiculo com abstract pra nao pode ser estanciada
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

//metodo para sobreescrever na classe moto e carro
//sobreescrevo o metodo imprimirDados
        public virtual void ImprimirDados()
        {
            Console.WriteLine($" Marca: {Marca}, Modelo: {Modelo}, Placa: {Placa}");
        }

    }
}

