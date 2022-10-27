
namespace Models
{
    public class Caderno
    {
		private string cor;
		private string marca;
		private int quantPagina;
		private bool aberto;

		public string Cor
		{
			get { return cor; }
			set { cor = value; }
		}


		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}


		public int QuantPagina
		{
			get { return quantPagina; }
			set { quantPagina = value; }
		}


		public bool Aberto
		{
			get { return aberto; }
			set { aberto = value; }
		}



		public Caderno(string _cor, string _marca)
		{
            Cor = _cor;
            Marca = _marca;
			quantPagina = 200;
			aberto = false;
        }

		public void Fechar()
		{
			Aberto = false;
		}

		public void Abrir()
		{
			Aberto = true;
		}

		public void ArrancarPag()
		{
			if(QuantPagina > 0)
			{
				QuantPagina -= 1;
				return;
			}
		}

	}
}
