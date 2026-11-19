using System.Runtime.Intrinsics.X86;

public class Pilha
{
    public Money? Head { get; set; } = null;

    public bool isEmpty()
    {
        return Head is null;
    }

    public void AddElement(Money m)
    {
        m.Next = Head;
        Head = m;
    }

    public void RemoveElement() 
    {
        Head = Head.Next;
    }

    public void ShowStack()
    {
        var aux = Head;
        do
        {
            Console.WriteLine(aux);
            aux = aux.Next;
        } while (aux is not null);
    }

    public int ElementCount()
    {
        if (isEmpty()) 
            return 0;

        var aux = Head;
        int count = 0;
        do
        {
            count++;
            aux = aux.Next;
        } while (aux is not null);
        return count;
    }

}



