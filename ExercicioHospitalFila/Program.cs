FilaSenha filaComum = new FilaSenha();
FilaSenha filaPrioritaria = new FilaSenha();


void InserirFilaComum()
{
    Senha comum = new Senha("C");
    filaComum.InserirElemento(comum);
}

void InserirFilaPrioritaria()
{
    Senha prioritaria = new Senha("P");
    filaPrioritaria.InserirElemento(prioritaria);
}

void AdicionarElementosFila()
{
    string opcao;
    do
    {
        Console.WriteLine("" +
            "[1] - SENHA NORMAL\n" +
            "[2] - SENHA PRIORITARIA\n" +
            "[0] - sair");
        Console.Write("Digite qual tipo de senha deseja retirar: ");
        opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                InserirFilaComum();
                break;

            case "2":
                InserirFilaPrioritaria();
                break;

            case "0":
                Console.WriteLine("Saindo");
                break;
        }
    } while (opcao != "0");
}

void OrdemAtendimento()
{
    // faz até 2 senhas prioritárias
    for (int i = 0; i < 2; i++)
    {
        if (!filaPrioritaria.FilaVazia())
        {
            Senha removida = filaPrioritaria.Head;
            filaPrioritaria.RemoverElemento();

            Console.WriteLine("Atendendo: " + removida.Codigo);
            Thread.Sleep(Random.Shared.Next(3, 11) * 1000);
        }
    }

    // faz 1 senha comum
    if (!filaComum.FilaVazia())
    {
        Senha removida = filaComum.Head;
        filaComum.RemoverElemento();

        Console.WriteLine("Atendendo: " + removida.Codigo);
        Thread.Sleep(Random.Shared.Next(3, 11) * 1000);
    }
}
void ChamarAtendimento()
{
    while(!filaComum.FilaVazia() || !filaPrioritaria.FilaVazia())
    {
        OrdemAtendimento();
    }
}

AdicionarElementosFila();
filaComum.MostrarFila();
filaPrioritaria.MostrarFila();
ChamarAtendimento();
filaComum.MostrarFila();
filaPrioritaria.MostrarFila();
