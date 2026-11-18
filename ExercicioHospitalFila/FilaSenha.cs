public class FilaSenha
{
    public Senha Head;
    public Senha Tail;
    public int Contador;

    public FilaSenha()
    {
        Head = Tail = null;
        Contador = 0;
    }

    public bool FilaVazia()
    {
        if (Head == null) //NESTE caso apenas o head determina se a fila esta vazia
        {
            return true;
        }
        else
            return false;
    }

    public void InserirElemento(Senha aux)
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

    }

    public void MostrarFila()
    {
        Senha s = Head;
        for (int i = 0; i <= Contador; i++)
        {
            if (s == null)
            {
                Console.WriteLine("Acabou a fila");
                break;
            }
            Console.Write(s.Codigo + " => ");
            s = s.Proximo;
        }
    }
}

