namespace Models
{
    public class Pneu
    {
        private int aro;
        private string marca;
        private bool furado;
        private int psi;
        private bool estourado;
        private double percentualBorracha;
        private int rotacao;

        public int Rotacao
        {
            get { return rotacao;}
            set { rotacao = value; }
        }


        public double PercentualBorracha
        {
            get { return percentualBorracha; }
            set { percentualBorracha = value; }
        }

        public bool Estourado
        {
            get { return estourado; }
            set { estourado = value; }
        }

        public int Psi
        {
            get { return psi; }
            set { psi = value; }
        }

        public bool Furado
        {
            get { return furado; }
            set { furado = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int Aro
        {
            get { return aro; }
            set { aro = value; }
        }
        public Pneu(int aro, string marca)
        {
            Aro = aro;
            Marca = marca;
            Furado = false;
            Psi = 33;
            Estourado = false;
            PercentualBorracha = 100;
            Rotacao = 0;
        }
        public void Girar(int _rotacao)
        {
            if (Furado || Estourado)
                return;

            Rotacao += _rotacao;
            GastarBorracha(_rotacao / 100.0);
        }
        public void Frear(int _abatimento)
        {
            Rotacao -= _abatimento;
            GastarBorracha(_abatimento / 100.0);
        }
        public void Furar()
        {
            Furado = true;
            Psi = 0;
        }
        public void Remendar()
        {
            Furado = false;
            Psi = 33;
        }
        private void GastarBorracha(double _quantidade)
        {
            PercentualBorracha -= _quantidade;
            if (PercentualBorracha <= 0)
                Estourar();
        }
        private void Estourar()
        {
            Estourado = true;
            Psi = 0;
            PercentualBorracha = 0;
            Rotacao = 0;
        }
        public void Exibir()
        {
            Console.WriteLine("Aro: " + Aro);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Furado: " + Furado);
            Console.WriteLine("Psi: " + Psi);
            Console.WriteLine("Estourado: " + Estourado);
            Console.WriteLine("Percentual de borracha: " + PercentualBorracha);
            Console.WriteLine("Rotação: " + Rotacao);
        }
    }
}