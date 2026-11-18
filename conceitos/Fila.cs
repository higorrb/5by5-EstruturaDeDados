public class Fila
{
    public Pessoa Head;
    public Pessoa Tail;
    public int Contador;

    public Fila()
    {
        Head = Tail = null;
        Contador = 0;
    }

    public bool FilaVazia()
    {
        if (Head == null)
        {
            return true;
        }
        else
            return false;
    }

    public void InserirElemento(Pessoa aux)
    {
        if (FilaVazia())
        {
            Head = aux;
            Tail = aux;
        }

        else
        {
            Tail.Proximo = aux;
            Tail = aux;
        }

        Contador++;
    }

    public int getContador()
    {
        return Contador;
    }

    public void RemoverElemento()
    {
        if (!FilaVazia())
        {
            Head = Head.Proximo;
            Contador--;
        }
        else
        {
            Head = Tail = null;
        }
    }

    public void MostrarFila()
    {
        Pessoa p = Head;
        for (int i = 0; i <= Contador; i++)
        {
            if (p == null)
            {
                Console.WriteLine("Acabou a fila");
                break;
            }
            Console.Write(p.Nome + " => ");
            p = p.Proximo;
        }
    }
}

