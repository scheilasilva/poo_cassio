  public class Personagem
    {
        public string Nome {get; set;}
        public int Forca{get; set;}
        public int Inteligencia{get; set;}
        public string Poderes{get; set;}
  
        public Personagem (string nome, int forca, int inteligencia, string poderes){

            Nome = nome;
            forca = forca;
            inteligencia = inteligencia;
            Poderes = poderes;
        }

        
    }
