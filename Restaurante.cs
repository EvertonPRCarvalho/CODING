public class Restaurante : Carrinho 
{
    private String codigo_restaurante;
    private String nome_restaurante;
    private String localidade_restaurante;
    private Carrinho carrinho;

    public Restaurante(string codigo, string nome, string localidade, Carrinho carrinho)
    {
        this.codigo_restaurante = codigo;
        this.nome_restaurante = nome;
        this.localidade_restaurante = localidade;
        this.Carrinho = new Carrinho();
    }

    public string Codigo_restaurante { get => codigo_restaurante; set => codigo_restaurante = value; }
    public string Nome_restaurante { get => nome_restaurante; set => nome_restaurante = value; }
    public string Localidade_restaurante { get => localidade_restaurante; set => localidade_restaurante = value; }
    public Carrinho Carrinho { get => carrinho; set => carrinho = value; }
}