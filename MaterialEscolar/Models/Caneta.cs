namespace Models
{
    public class Caneta
    {
        private string cor;
        private string marca;
        private int percentualCarga;
        private double tamanho;
        private double peso;
        private bool tampada;
        private string materia;
        private double ponta;
        private string tipoPonta;
        private bool caida;
        private bool estourada;


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


        public int PercentualCarga
        {
            get { return percentualCarga; }
            set { percentualCarga = value; }
        }


        public double Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }


        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }


        public bool Tampada
        {
            get { return tampada; }
            set { tampada = value; }
        }


        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }


        public double Ponta
        {
            get { return ponta; }
            set { ponta = value; }
        }


        public string TipoPonta
        {
            get { return tipoPonta; }
            set { tipoPonta = value; }
        }


        public bool Caida
        {
            get { return caida; }
            set { caida = value; }
        }


        public bool Estourada
        {
            get { return estourada; }
            set { estourada = value; }
        }



       public Caneta(string _cor, string _marca, string _materia)
        {
            Cor = _cor;
            Marca = _marca;
            percentualCarga =100;
            Materia = _materia;
         
        }

        public void Cair()
        {
            Caida = true;
        }

        public void PedarDoChao()
        {
            Caida = false;
        }

        public void Tampar()
        {
            Tampada = true;
        }

        public void Destampar()
        {
            Tampada = false;
        }

        public void Escrever(string _texto)
        {
            if (Tampada == true)
            {
                Console.WriteLine("não é possível escrever com a caneta tampada");
                return;
            }

            if (Caida == true)
            {
                Console.WriteLine("pegue a caneta do chão");
                return;
            }

            if (PercentualCarga == 0)
            {
                Console.WriteLine("a caneta não possui tinta");
                return;
            }

            if (Estourada == true)
            {
                Console.WriteLine("a caneta está estourada");
                return;
            }
            Console.WriteLine(_texto);
            Gastartinta();
        }

        private void Gastartinta()
        {
            PercentualCarga -= 10;
        }

        public void Exibir()
        {
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("% de carga: " + PercentualCarga);
            Console.WriteLine("Materia: " + Materia);
            Console.WriteLine("Tampada: " + Tampada);


        }
           
    }
}