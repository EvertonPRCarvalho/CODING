using System;
using System.Collections;
public class Carrinho : Produto 
{
    private List<Produto> produtos;

    public Carrinho() //Construtor da classe
    {
        this.produtos = new List<Produto>(); 
    } 

    public void Adicionar(Produto p)
    {
        produtos.Add(p);
    }
/*
    public void Excluir(Produto nome_produto)
    {
        produtos.Remove(produto.Nome(nome_produto));
    }

    public void ListarProd()
    {
        
    }
    */
}
