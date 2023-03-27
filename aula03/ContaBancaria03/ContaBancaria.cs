    public class ContaBancaria
    {
        public double saldo{ get; private set;}
        public int numero{get; private set;}

        public ContaBancaria(int numero){
               this.numero = numero;
               this.salso = 0.0;
        }
        public void depositar (double valor){
            this.saldo += valor;
        }
        public void sacar (double valor){
            
        }
    }
