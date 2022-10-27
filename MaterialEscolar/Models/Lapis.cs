namespace Models
{
    public class Lapis
    {
		private string dureza;
		private bool apontado;
		private int percentualGrafite;

		public string Dureza
		{
			get { return dureza; }
			set { dureza = value; }
		}


		public bool Apontado
		{
			get { return apontado; }
			set { apontado = value; }
		}

		public int PercentualGrafite
		{
			get { return percentualGrafite; }
			set { percentualGrafite = value; }
		}


		public Lapis(string dureza)
		{
			Dureza = dureza;
			Apontado = true;
			PercentualGrafite = 100;
			
		}

		public void QuebrarPonta()
		{
			apontado = false;
			GastarGrafite(15);
		}

		

		public void Apontar()
		{
			if (PercentualGrafite < 5)
			{
				Console.WriteLine("compre outro lápis");
				return;
			}

			apontado=true;
			GastarGrafite(5);
		}

        private void GastarGrafite(int _percentual)
        {
			PercentualGrafite -= _percentual;
			if(PercentualGrafite < 0)
				PercentualGrafite = 0;
        }

		public void Escrever(string _texto)
		{
			if(PercentualGrafite < 10)
			{
				Console.WriteLine("Compre outro lápis.");
				return;
			}
			if(!Apontado)
			{
				Console.WriteLine("Aponte o lápis");
			}
			Console.WriteLine(_texto);
			GastarGrafite(10);
		}
    }

}
