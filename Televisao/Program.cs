using System;

 public class Televisao
    {
        private string nome;
        private bool ligada=false; //Por padrão a TV estará desligada
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
    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string novoNome)
    {
        nome = novoNome;
    }

}
    public class Controle : Televisao
    
    {

        public bool BtnLigaDesliga()
        {
            if (this.GetLigada())
                this.SetLigada(false);
            else
                this.SetLigada(true);
            return this.GetLigada();
        }

        public void BtnAumentarVol()
        {
            if (this.GetLigada())
            {
                if (this.GetVolume() <= 100)
                    this.SetVolume(this.GetVolume() + 10);
            }
        }
        public void BtnBaixarVol()
        {
            if (this.GetLigada())
            {
                if (this.GetVolume() > 0)
                    this.SetVolume(this.GetVolume() - 10);
            }
        }
        public void BtnAumentarCanal()
        {   
            if(this.GetLigada())
                this.SetCanal(this.GetCanal() + 1);

        }
        public void BtnBaixarCanal()
        {
            if(this.GetLigada())
                this.SetCanal(this.GetCanal() - 1);

        }
         static void Main(string[] args)
        {
            Controle tvSala = new();
            //As instruções abaixão seguem como padrão para o início de cada TV.
            tvSala.SetNome("TV-SALA");
            tvSala.BtnLigaDesliga();
            tvSala.BtnAumentarVol();
            tvSala.BtnAumentarVol();
            tvSala.BtnAumentarCanal();
            tvSala.BtnBaixarVol();
            tvSala.BtnAumentarCanal();
            //A linha abaixo é ilustrativa, tem o objetivo de mostrar que nenhuma ação ocorre se a Televisão tiver o parâmetro ligada=false
            tvSala.BtnLigaDesliga();
            tvSala.BtnBaixarVol();
            tvSala.BtnAumentarCanal();


            Console.WriteLine(tvSala.GetNome());
            Console.WriteLine("Volume: "+ tvSala.GetVolume());
            Console.WriteLine("Canal: "+tvSala.GetCanal());
        }

    }


