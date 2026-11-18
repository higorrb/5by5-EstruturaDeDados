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

}

