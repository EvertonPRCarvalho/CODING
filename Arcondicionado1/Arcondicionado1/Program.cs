using System;

public class ArCondicionado
{
    private bool ligado=false;
    private int graus=28; //Por definição a temperatura será de 28º, simulando a temperatura do Recife
    private bool ventilar;
    
    //MÉTODOS GETs E SETs PARA ALTERAR OS PARÂMETRO DA CLASSE
    public bool GetLigado()
    {
        return ligado;
    }
    public void SetLigado(bool LigadoDesligado)
    {
        ligado = LigadoDesligado;
        
    }
    public int GetGraus()
    {
        return graus;
    }
    public void SetGraus(int novoGraus)
    {
        graus = novoGraus;

    }
    public bool GetVentilar()
    {
        return ventilar;
    }
    public void SetVentilar(bool novoVentilar)
    {
        ventilar = novoVentilar;

    }
}

public class Controle : ArCondicionado
{   
    //MÉTODOS PARA MANIPULAR OS PARÂMETROS DA CLASSE ArCondicionado HERDADA PELA CLASSE Controle
    public void BtnLigaDesliga() //SE ESTIVER LIGADO, ENTÃO DELIGA. SE ESTIVER DESLIGADO, ENTÃO LIGA.
    {
        if (this.GetLigado())
            this.SetLigado(false);
        else
            this.SetLigado(true);

    }
    public void BtnAumentarTemp()
    {
        if (this.GetLigado()) // NÃO PODE HAVER ALTERAÇÃO DO PARâMETRO TEMPERATURA SE O ARCONDICIONADO ESTIVER DESLIGADO
        {
            if (this.GetGraus()<=35) //HÁ UM LIMITE MÁXIMO QUE, NESTE CASO, É DE 35º.
            {
                this.SetGraus(this.GetGraus() + 1);
            }
        }
    }
    public void BtnBaixarTemp()
    {
        if (this.GetLigado())
        {
            if (this.GetGraus() > 15) //HÁ UM LIMITE MÍNIMO QUE, NESTE CASO, É DE 15º.
            {
                this.SetGraus(this.GetGraus() - 1);
            }
        }

    }

    public void BtnVentilar()
    {
        if (this.GetLigado()) //A FUNÇÃO VENTILAR SÓ PODE ACONTECER SE O ARCONDICIONADO ESTIVER LIGADO
        {
            if(this.GetVentilar()) //SE ESTIVER VENTILANDO ENTÃO, APÓS ACIONAR ESTE BOTÃO, PASSA
            {
                this.SetVentilar(false);
            }
            else                   //DO CONTRÁRIO, SE NÃO ESTIVER VENTILANDO ENTÃO, APÓS ACIONAR ESTE BOTÃO, PASSA A VENTILAR
            {
                this.SetVentilar(true);
            }
        }
    }
    static void Main(String[] args)
    {
        //UM EXEMPLO DO USO DO Controle DO ArCondicionado 
        Controle arcond1 = new();
        arcond1.BtnLigaDesliga();
        arcond1.BtnBaixarTemp(); //Baixar a temperatura em 1º. temperatura = 27
        arcond1.BtnBaixarTemp(); //Baixar a temperatura em 1º. temperatura = 26
        arcond1.BtnBaixarTemp(); //Baixar a temperatura em 1º. temperatura = 25
        arcond1.BtnBaixarTemp(); //Baixar a temperatura em 1º. temperatura = 24
        arcond1.BtnBaixarTemp(); //Baixar a temperatura em 1º. temperatura = 23
        arcond1.BtnAumentarTemp(); //Aumentar a temperatura em 1º. temperatura = 24
        arcond1.BtnVentilar(); //Ventilar passa a ser TRUE. 
        Console.WriteLine(arcond1.GetLigado());
        Console.WriteLine(arcond1.GetGraus());
        Console.WriteLine(arcond1.GetVentilar());
        arcond1.BtnVentilar(); //Ventilar passa a ser FALSE. 
        Console.WriteLine(arcond1.GetVentilar());
    }
}





