namespace aula05
{
    class Progam
    {
        static List<Pessoa> listarPessoas = new List<Pessoa>();
        static List<Cidade> listarCidades = new List<Cidade>();


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha um opção: ");
                Console.WriteLine("1 - Adicionar pessoa");
                Console.WriteLine("2 - Atualizar pessoa");
                Console.WriteLine("3 - Excluir pessoa");
                Console.WriteLine("4 - Listar pessoas");
                Console.WriteLine("5 - Adicionar cidade");
                Console.WriteLine("6 - Atualizar cidade");
                Console.WriteLine("7 - Excluir cidade");
                Console.WriteLine("8 - Listar cidade");
                Console.WriteLine("9 - Sair");

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
                        AdicionarCidade();
                        break;
                    case 6:
                        AtualizarCidade();
                        break;
                    case 7:
                        ExcluirCidade();
                        break;
                    case 8:
                        ListarCidades();
                        break;
                    case 9:
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

            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Adicionar uma cidade existente");
            Console.WriteLine("2 - Adicionar uma nova cidade");

            int opcao = Convert.ToInt32(Console.ReadLine());

            Cidade cidade = new Cidade();

            if (opcao == 1)
            {
                Console.WriteLine("Informe o Id da cidade: ");
                int cidadeId = Convert.ToInt32(Console.ReadLine());

                cidade = listarCidades.Find(cidade => cidade.Id == cidadeId);
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Informe o nome da cidade: ");
                string cidadeNome = Console.ReadLine();

                int cidadeId = listarCidades.Count + 1;

                cidade = new Cidade { Id = cidadeId, Nome = cidadeNome };
                listarCidades.Add(cidade);
            }

            int id = listarPessoas.Count + 1;

            Pessoa pessoa = new Pessoa { Id = id, Nome = nome, Telefone = telefone, Cidade = cidade };
            listarPessoas.Add(pessoa);

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
                Console.WriteLine("Id: {0}, Nome: {1}, Telefone: {2}, Cidade: {3}", pessoa.Id, pessoa.Nome, pessoa.Telefone, pessoa.Cidade);
            }
        }

        static void AdicionarCidade()
        {
            Console.WriteLine("Informe o nome da cidade: ");
            string nome = Console.ReadLine();

            int id = listarCidades.Count + 1;

            Cidade cidade = new Cidade { Id = id, Nome = nome };
            listarCidades.Add(cidade);

            Console.WriteLine("Cidade adicionada");
        }

        static void AtualizarCidade()
        {
            Console.WriteLine("Informe o id da cidade: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Cidade cidade = listarCidades.Find(cidade => cidade.Id == id);

            if (cidade != null)
            {
                Console.WriteLine("Informe o novo nome da cidade: ");
                string nome = Console.ReadLine();

                cidade.Nome = nome;

                Console.WriteLine("Cidade atualizada");
            }
            else
            {
                Console.WriteLine("Cidade não encontrada");

            }
        }

        static void ExcluirCidade()
        {
            Console.WriteLine("Informe o ID da cidade: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Cidade cidade = listarCidades.Find(c => c.Id == id);

            if (cidade != null)
            {
                listarCidades.Remove(cidade);

                listarPessoas.RemoveAll(p => p.Cidade.Id == id);

                Console.WriteLine("Cidade excluída com sucesso");
            }
            else
            {
                Console.WriteLine("Cidade não encontrada");
            }
        }

        static void ListarCidades()
        {
            foreach (Cidade cidade in listarCidades)
            {
                Console.WriteLine("ID: {0}, Nome: {1}", cidade.Id, cidade.Nome);
            }
        }
    }
}