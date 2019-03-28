using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace ArquivoApp
{
    public partial class MainPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //Navigation.PushAsync(new Consumo());
            string nomeArquivo = Path.GetRandomFileName();
            label_inicial.Text = nomeArquivo + ".txt";
        }

        public MainPage()
        {
            InitializeComponent();
            label_inicial.Text = App.ValorDesteContexto;
            editor_valor.Text = App.PastaDiretorio;
        }
    }
}
