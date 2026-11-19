int contador = 0;

FilaSenha filaComum = new FilaSenha();
FilaSenha filaPrioritaria = new FilaSenha();


//ADD SENHAS NAS FILAS
void InserirFilaComum()
{
    Senha comum = new Senha("C");
    filaComum.InserirElemento(comum);
}

void InserirFilaPrioritaria()
{
    filaPrioritaria.InserirElemento(new Senha("P")); // posso add a nova senha direto no parametro
}

//MENU E ATENDIENTO
string Menu()

{
    Console.WriteLine("" +
            "[1] - SENHA COMUM\n" +
            "[2] - SENHA PRIORITARIA\n" +
            "[3] - CHAMAR ATENDIMENTO\n" +
            "[0] - sair");
    Console.Write("Digite qual tipo de senha deseja retirar: ");
    string opcao = Console.ReadLine();
    return opcao;
}

void Atender()
{
    string opcao;
    do
    {
        switch (Menu())
        {
            case "1":
                InserirFilaComum();
                break;

            case "2":
                InserirFilaPrioritaria();
                break;

            case "3":
                ChamarAtendimento();
                break;

            case "0":
                Console.WriteLine("Saindo");
                break;
        }
    } while (Menu() != "0");
}

//INDICAR A PROXIMA SENHA
void OrdemAtendimento()
{
    /*
    if (contador < 2 && !filaPrioritaria.FilaVazia())
    {

        Console.WriteLine("Atendendo: " + filaPrioritaria.Head.Codigo);
        filaPrioritaria.RemoverElemento();
        Thread.Sleep(Random.Shared.Next(3, 11) * 1000);

        contador++;

    }
    else if(!filaComum.FilaVazia())
    {
        Console.WriteLine("Atendendo: " + filaComum.Head.Codigo);
        filaComum.RemoverElemento();
        Thread.Sleep(Random.Shared.Next(3, 11) * 1000);

        contador = 0;
    }
    else
    {
        Console.WriteLine("As filas estao vazias");
    }

    */

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
    while (!filaComum.FilaVazia() || !filaPrioritaria.FilaVazia())
    {
        OrdemAtendimento();
    }
}


filaComum.MostrarFila();
filaPrioritaria.MostrarFila();
Atender();
filaComum.MostrarFila();
filaPrioritaria.MostrarFila();
