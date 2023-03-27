public class Pessoa
{
    public string Nome{get; set;}
    public int idade {get; set;}

    public void apresentar(){
        console.WriteLine("meu nome é:"+Nome+ "e tenho:" +idade+ "anos");
    }
} 