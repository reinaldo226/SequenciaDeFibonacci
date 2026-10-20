using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SequenciaDeFibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            long limite;

            if (string.IsNullOrWhiteSpace(txtLimite.Text))
            {
                ExibirErro("Digite um número limite.");
                txtLimite.Focus();
                return;
            }

            if (!long.TryParse(txtLimite.Text, out limite))
            {
                ExibirErro("Digite um número inteiro válido.");
                txtLimite.SelectAll();
                txtLimite.Focus();
                return;
            }

            if (limite < 0)
            {
                ExibirErro("Digite um número maior ou igual a zero.");
                txtLimite.SelectAll();
                txtLimite.Focus();
                return;
            }

            try
            {
                List<long> fibonacci = GerarFibonacci(limite);
                txtSequencia.Text = string.Join(", ", fibonacci);
                lblStatus.Text = string.Format("{0} termos gerados até o limite {1:N0}.", fibonacci.Count, limite);
                lblStatus.ForeColor = Color.FromArgb(5, 150, 105);
            }
            catch (OverflowException)
            {
                ExibirErro("O limite informado é grande demais para calcular com segurança.");
            }
        }

        private List<long> GerarFibonacci(long limite)
        {
            List<long> fibonacci = new List<long> { 0, 1 };
            long anterior = 0;
            long atual = 1;

            while (true)
            {
                long proximo;

                checked
                {
                    proximo = anterior + atual;
                }

                if (proximo > limite)
                    break;

                fibonacci.Add(proximo);
                anterior = atual;
                atual = proximo;
            }

            return fibonacci;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLimite.Clear();
            txtSequencia.Clear();
            lblStatus.Text = "Digite um limite e clique em Gerar sequência.";
            lblStatus.ForeColor = Color.FromArgb(100, 116, 139);
            txtLimite.Focus();
        }

        private void txtLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ExibirErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            lblStatus.Text = mensagem;
            lblStatus.ForeColor = Color.FromArgb(220, 38, 38);
        }
    }
}
