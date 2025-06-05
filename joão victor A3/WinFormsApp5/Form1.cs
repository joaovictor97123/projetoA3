namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }

        private Operacao Operacaoselecionada { get; set; }
        enum Operacao
        {
            Adicao,
            Substacao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            Operacaoselecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            iblOperacao.Text = "+";
        }

        private void btnsubstacao_Click(object sender, EventArgs e)
        {
            Operacaoselecionada = Operacao.Substacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            iblOperacao.Text = "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Operacaoselecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            iblOperacao.Text = "x";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Operacaoselecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            iblOperacao.Text = "/";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            iblOperacao.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            {
                decimal segundoValor = Convert.ToDecimal(txtResultado.Text);

                switch (Operacaoselecionada)
                {
                    case Operacao.Adicao:
                        Resultado = Valor + segundoValor;
                        break;
                    case Operacao.Substacao:
                        Resultado = Valor - segundoValor;
                        break;
                    case Operacao.Divisao:
                        Resultado = segundoValor != 0 ? Valor / segundoValor : 0; // evita divisão por zero
                        break;
                    case Operacao.Multiplicacao:
                        Resultado = Valor * segundoValor;
                        break;
                }

                txtResultado.Text = Convert.ToString(Resultado);
                iblOperacao.Text = "=";
            } 



        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(".."))
                txtResultado.Text += ",";
        }
    }
}

        
      

       