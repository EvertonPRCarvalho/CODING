public class Estoque : Produto 
{
    private List<Produto> produtos_estoque;

    public Estoque(){}
    public Estoque(string nome, string validade, double preco) : base(nome, validade, preco)
    {
        this.produtos_estoque = new List<Produto>();
    }

    public void Adicionar(Produto produto)
    {
        this.produtos_estoque.Add(produto);
    }
/*
     public void Excluir(Produto nome_produto)
    {
        produtos.Remove(produto.Nome(nome_produto));
    }

    public void ListarEstoque(){

    }
*/
}
