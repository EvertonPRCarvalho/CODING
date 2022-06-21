public class Produto
{
    private int codigo;
    private String nome;
    private String validade;
    private double preco;

    public Produto(string nome, string validade, double preco)
    {
        this.nome = nome;
        this.validade = validade;
        this.preco = preco;
    }
    public Produto(){}
    public int Codigo { get => codigo; set => codigo = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Validade { get => validade; set => validade = value; }
    public double Preco { get => preco; set => preco = value; }
}