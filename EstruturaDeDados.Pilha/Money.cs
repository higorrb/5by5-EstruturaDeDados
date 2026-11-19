public class Money(int v = 100) //caso nao coloque nada no parametro ele coloca 100 como padrao
{
    public int Value { get; private set; } = v; // = 100; é o construtor primario, todo Money q sera criado, o valor inicial de Value é 100

    public Money? Next { get; set; } = null;

    public override string ToString()
    {
        return $"[{Value.ToString()}]";
    }

}

