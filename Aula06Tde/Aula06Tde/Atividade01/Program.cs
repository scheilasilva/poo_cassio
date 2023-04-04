using Aula06Tde;

public class Program
{
    public static void Main(string[] args)
    {
        Animal Cachorro = new Cachorro();
        Cachorro.Nome = "Toby";
        Cachorro.falar();
        
        Animal Gato = new Gato();
        Gato.Nome = "lua";
        Gato.falar();
    }
}
