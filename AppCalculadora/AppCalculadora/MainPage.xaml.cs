using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalculadora
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        void btnCalcular(object sender, System.EventArgs e)
        {
            int Porcentagem = Convert.ToInt32(txtPorcentagem.Text);

            int Total = Convert.ToInt32(txtValorTotal.Text);

            int Parcelas = Convert.ToInt32(txtNumeroParcelas.Text);
            string DescAcr = txtDesconto.Text;
            if (DescAcr == "Desconto")
            {
                int valorparcelas = 0;
                int valorfinal = 0;
                int valorporc = 0;
                valorporc = (Total * Porcentagem) / 100;
                valorfinal = Total - valorporc;
                valorparcelas = valorfinal / Parcelas;

                string valorporc1 = valorporc.ToString();
                string valorfinal1 = valorfinal.ToString();
                string valorparcelas1 = valorparcelas.ToString();
                txtValorParcelas.Text = valorparcelas1;
                txtValorPagar.Text = valorfinal1;

            }

            if (DescAcr == "Acrescimo")
            {
                int valorparcelas = 0;
                int valorfinal = 0;
                int valorporc = 0;
                valorporc = (Total * Porcentagem) / 100;
                valorfinal = Total + valorporc;
                valorparcelas = valorfinal / Parcelas;

                string valorporc1 = valorporc.ToString();
                string valorfinal1 = valorfinal.ToString();
                string valorparcelas1 = valorparcelas.ToString();
                txtValorParcelas.Text = valorparcelas1;
                txtValorTotal.Text = valorfinal1;
            }
        }
    }
}
