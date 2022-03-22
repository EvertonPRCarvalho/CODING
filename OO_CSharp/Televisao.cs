using System;

public class Televisao
{
    private bool ligada;
    private float canal;
    private int volume;
    
    public bool GetLigada()
    {
        return ligada;
    }
    
    public void SetLigada(bool novoStatus)
    {
        ligada = novoStatus;
    }
    public float GetCanal()
    {
        return canal;
    }

    public void SetCanal(float novoCanal)
    {
        canal = novoCanal;
    }
    public int GetVolume()
    {
        return volume;
    }

    public void SetVolume(int novoVolume)
    {
        volume = novoVolume;
    }
}
public class Controle : Televisao
        //private bool ligada;
        //private float canal;
        //private int volume;
{
    Televisao tvSala = new();

    public void BtnLigaDesliga()
    {
        if (tvSala.GetLigada())
            tvSala.SetLigada(false);
        else
            tvSala.SetLigada(true);
    }

    public void BtnAumentarVol()
    {
        if (tvSala.GetLigada())
        {
            if (tvSala.GetVolume() <= 100)
                tvSala.SetVolume(tvSala.GetVolume()+1);
        }
    }
    public void BtnBaixarVol()
    {
        if (tvSala.GetLigada())
        {
            if (tvSala.GetVolume() > 0)
                tvSala.SetVolume(tvSala.GetVolume() - 1);
        }
    }
    public void BtnAumentarCanal()
    {
        tvSala.SetCanal(tvSala.GetCanal()+1);

    }
    public void BtnBaixarCanal()
    {
        tvSala.SetCanal(tvSala.GetCanal() - 1);

    }
}

