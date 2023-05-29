using Aula08Ap1;

class Program
{
// lista de veículos contém instâncias de objetos das classes Moto e Carro

    static void Main(string[] args)
    {

        List<Veiculo> veiculos = new List<Veiculo>();
        int vagasDisponiveis = 10;


        while (true)
        {
            Console.WriteLine("-> Estacionamento <-");
            Console.WriteLine("1 - Estacionar carro");
            Console.WriteLine("2 - Estacionar moto");
            Console.WriteLine("3 - Listar veiculos estacionados");
            Console.WriteLine("4 - Total vagas disponíveis");
            Console.WriteLine("5 - Remover veiculo");
            Console.WriteLine("0 - Sair");


            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    if (vagasDisponiveis > 0)
                    {

                        Console.Write("Marca do carro: ");
                        string marcaCarro = Console.ReadLine();

                        Console.Write("Modelo do carro: ");
                        string modeloCarro = Console.ReadLine();

                        Console.Write("Placa do carro: ");
                        string placaCarro = Console.ReadLine();

                        Console.WriteLine("Numero de portas: ");
                        int numeroPortas = Convert.ToInt32(Console.ReadLine());

                        veiculos.Add(new Carro(marcaCarro, modeloCarro, placaCarro, numeroPortas));
                        Console.WriteLine("Carro estacionado com sucesso");
                        vagasDisponiveis--;
                    }
                    else
                    {
                        Console.WriteLine("Não há vagas disponiveis!");
                    }
                    break;

                case "2":
                    if (vagasDisponiveis > 0)
                    {
                        Console.WriteLine("Digite a marca da moto: ");
                        string marcaMoto = Console.ReadLine();

                        Console.WriteLine("Digite a o modelo da moto: ");
                        string modeloMoto = Console.ReadLine();

                        Console.WriteLine("Placa da moto: ");
                        string placaMoto = Console.ReadLine();

                        Console.WriteLine("Cilindrada: ");
                        int cilindrada = Convert.ToInt32(Console.ReadLine());

                        veiculos.Add(new Moto(marcaMoto, modeloMoto, placaMoto, cilindrada));
                        Console.WriteLine("Moto estacionada com sucesso");
                        vagasDisponiveis--;
                    }
                    else
                    {
                        Console.WriteLine("Não há vagas disponiveis!");
                    }
                    break;

                case "3":
                    Console.WriteLine("Veiculos estacionados: ");
                    foreach (Veiculo veiculo in veiculos)
                    {
                        veiculo.ImprimirDados();
                    }
                    break;

                case "4":
                    Console.WriteLine($"Vagas disponiveis: {vagasDisponiveis}");
                    break;

                case "5":
                    Console.WriteLine("Digite a placa do veiculo a ser removido: ");
                    string placaRemover = Console.ReadLine();
                    for (int i = 0; i < veiculos.Count; i++)
                    {
                        if (veiculos[i].Placa == placaRemover)
                        {
                            veiculos.RemoveAt(i);
                            Console.WriteLine("Veiculo removido com sucesso!");
                            vagasDisponiveis++;
                            break;
                        }
                        else if (i == veiculos.Count - 1)
                        {
                            Console.WriteLine("Veiculo não encontrado");
                        }
                    }
                    break;


                case "0":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
