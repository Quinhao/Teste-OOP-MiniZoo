public class Leao : Mamifero
{
    public int TamanhoDoGrupo { get; set; }
    public Leao(string nome, int idade, int tamanhoDoGrupo) : base(nome, idade)
    {
        TamanhoDoGrupo = tamanhoDoGrupo;
    }
}