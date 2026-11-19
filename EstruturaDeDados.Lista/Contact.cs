public class Contact(string name)
{
    // public int Id { get; set; }

    public string Name { get; private set; } = name;

    public string Phone { get; set; }

    public char Gender { get; set; }

    public override string ToString()
    {
        return $"""
            Nome: {Name} 
            Telefone: {Phone}
            Sexo: {Gender}
            """;
    }

}

