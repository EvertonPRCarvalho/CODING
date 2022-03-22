using System;


public class Personagem
{
    private String nome;
    private int id;
    private int vida;
    private int xp;
    private bool parar = true;
    private bool correr = false;
    private bool andar = false;
    private readonly string[] habilidade = new string[5];
    public int indece = 0;

    //MÉTODOS GETs E SETs PARA CONSULTA E MANIPULAÇÃO DOS ATRIBUTOS 
    public void Set_nome(String novo_nome) 
    {
        nome = novo_nome;
    }
    public String Get_nome()
    {
        return nome;
    }
    public void Set_id(int novo_id)
    {
        id = novo_id;
    }
    public int Get_id()
    {
        return id;
    }

    public void Set_vida(int novo_vida)
    {
        vida = novo_vida;
    }
    public int Get_vida()
    {
        return vida;
    }

    public void Set_xp(int novo_xp)
    {
        xp = novo_xp;
    }
    public int Get_xp()
    {
        return xp;
    }

    public void Set_andar(bool novo_andar)
    {
        andar = novo_andar;
    }
    public bool Get_andar()
    {
        return andar;
    }

    public void Set_correr(bool novo_correr)
    {
        correr = novo_correr;
    }
    public bool Get_correr()
    {
        return correr;
    }

    public void Set_parar(bool novo_parar)
    {
        parar = novo_parar;
    }
    public bool Get_parar()
    {
        return parar;
    }

    public void Set_habilidade(String novo_habilidade, int indice)
    {
        habilidade[indice] = novo_habilidade;
    }
    public String Get_habilidade(int indice)
    {
        return habilidade[indice];
    }

  
}
//A CLASSE JOGO CONTÉM A LÓGICA DO PROGRAMA, OU SEJA, OS MÉTODOOS DA CLASSE PERSONAGEM
//SERÃO UTILIZADOS AQUI COM BASE NA LÓGICA DO PRODUTO (NESTE CASO, DO JOGO).
class Jogo : Personagem
{
    Personagem personagem1 = new Personagem();
    
    public void Parar()
        //O MÉTODO Parar GARANTE QUE O PERSONAGEM PARE, SE ESTIVER ANDANDO OU CORRENDO
    {
       if (personagem1.Get_parar() == false)
        {
            personagem1.Set_parar(true);
 
        }
    }
    public void Andar()
        //O MÉTODO Andar GARANTE QUE O PERSONAGEM ANDE APENAS SE NÃO ESTIVER PARADO
    {
        if (personagem1.Get_parar() == true)
        {
            personagem1.Set_parar(false);
            personagem1.Set_andar(true);
        } else
        {
            if (personagem1.Get_correr() == true)
            {
                personagem1.Set_correr(false);
            }
            personagem1.Set_andar(true);
        }
    }
  
    

    static void Main()
    {
        /*
        
        [ x ] NOME
        [ x ] ID
        [ x ] VIDA
        [ x ] XP
        [ x ] ANDAR
        [ x ] CORRER
        [ x ] PARAR
        [ x ] HABILIDADE

        */
        Personagem personagem1 = new();
        personagem1.Set_id(1);
        personagem1.Set_nome("Everton");
        personagem1.Set_xp(1);
        personagem1.Set_vida(100);
        personagem1.Set_habilidade("Supervelocidade", 0);
        personagem1.Set_parar(true);
        personagem1.Set_andar(false);

        Console.WriteLine("Nome: " + personagem1.Get_nome());
        Console.WriteLine("ID: " + personagem1.Get_id());
        Console.WriteLine("XP: * " + personagem1.Get_xp());
        Console.WriteLine("[==========]: " + personagem1.Get_vida());
        Console.WriteLine("Habilidade: " + personagem1.Get_habilidade(0));
        Console.WriteLine("Parado: " + personagem1.Get_parar());
        Console.WriteLine("Andar: " + personagem1.Get_andar());
        Console.WriteLine("----------ANDANDO----------");

        personagem1.Set_parar(false);
        personagem1.Set_andar(true);

        Console.WriteLine("Parado: " + personagem1.Get_parar());
        Console.WriteLine("Andar: " + personagem1.Get_andar());

        Console.WriteLine("----------PERDENDO VIDA----------");

        personagem1.Set_vida(80);
        Console.WriteLine("[========  ]: " + personagem1.Get_vida());

        Console.WriteLine("---------GANHANDO XP---------");
        personagem1.Set_xp(5);
        Console.WriteLine("XP: ***** " + personagem1.Get_xp());


    }

}