using System;

    public class Veiculo
    {
        public string Modelo { get; set; }

//
        public virtual void Acelerar(){
          
        }
    }

    public class Carro : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando Carro: " + Modelo);

        }

        public class Moto : Veiculo
        {
            public override void Acelerar()
            {
                Console.WriteLine("Acelerando Moto: " + Modelo);
            }
        }

    }