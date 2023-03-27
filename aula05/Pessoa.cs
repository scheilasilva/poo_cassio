public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public Cidade Cidade { get; set; }

    public Pessoa()
    {
        Id = Id;
        Nome = Nome;
        Telefone = Telefone;
        Cidade = new Cidade();
    }
}

