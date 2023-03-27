namespace aula04Tde
{
class Progam
{
    static List<Pessoa> listarPessoas = new List<Pessoa>();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Escolha um opção: ");
            Console.WriteLine("1 - Adicionar pessoa");
            Console.WriteLine("2 - Atualizar pessoa");
            Console.WriteLine("3 - Excluir pessoa");
            Console.WriteLine("4 - Listar pessoas");
            Console.WriteLine("5 - Sair");

            int operador = Convert.ToInt32(Console.ReadLine());

            switch (operador)
            {
                case 1:
                    AdicionarPessoa();
                    break;
                case 2:
                    AtualizarPessoa();
                    break;
                case 3:
                    ExcluirPessoa();
                    break;
                case 4:
                    ListarPessoas();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }
        }
    }
    static void AdicionarPessoa()
    {
        Console.WriteLine("Informe o nome da pessoa: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe o telefone da pessoa: ");
        string telefone = Console.ReadLine();

        int id = listarPessoas.Count + 1;

        listarPessoas.Add(new Pessoa
        {
            Id = id,
            Nome = nome,
            Telefone = telefone
        });

        Console.WriteLine("Pessoa adicionada");
    }

    static void AtualizarPessoa()
    {
        Console.WriteLine("Informe o id da pessoa: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Pessoa pessoa = listarPessoas.Find(pessoa => pessoa.Id == id);

        if (pessoa != null)
        {
            Console.WriteLine("Informe o nome da pessoa: ");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Informe o telefone da pessoa: ");
            pessoa.Telefone = Console.ReadLine();

            Console.WriteLine("Pessoa atualizada");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada");
        }
    }

    static void ExcluirPessoa()
    {
        Console.WriteLine("Informe o Id da pessoa: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Pessoa pessoa = listarPessoas.Find(pessoa => pessoa.Id == id);

        if (pessoa != null)
        {
            listarPessoas.Remove(pessoa);
            Console.WriteLine("Pessoa excluida com sucesso");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada");
        }
    }

    static void ListarPessoas()
    {
        foreach (Pessoa pessoa in listarPessoas)
        {
            Console.WriteLine("Id: {0}, Nome: {1}, Telefone: {2}", pessoa.Id, pessoa.Nome, pessoa.Telefone);
        }
    }
}

}
