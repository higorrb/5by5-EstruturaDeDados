public class Senha
{
    public string Codigo { get; set; }

    public Senha Proximo;

    // tipo C para COMUM e P para Prioriataria
    public Senha(string tipo)
    {
        Codigo = GeradorSenha(tipo);
        Proximo = null;
    }

    public string GeradorSenha(string tipo)
    {
        return tipo.ToUpper() + Random.Shared.Next(0, 1000).ToString("D3");
    }

}

