using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace ArquivoApp
{
    public partial class MainPage : ContentPage
    {
        List<string> listaNome = new List<string>();
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //Navigation.PushAsync(new Consumo());
            string nomeArquivo = Path.GetRandomFileName();
            label_inicial.Text = nomeArquivo + ".txt";
            listaNome.Add(label_inicial.Text);
        }

        public MainPage()
        {
            InitializeComponent();
            label_inicial.Text = App.ValorDesteContexto;
            editor_valor.Text = App.PastaDiretorio;
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Consumo(listaNome));
        }
    }
}
