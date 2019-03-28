using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ArquivoApp
{
    public partial class MainPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Consumo());
        }

        public MainPage()
        {
            InitializeComponent();
            label_inicial.Text = App.ValorDesteContexto;
            editor_valor.Text = App.PastaDiretorio;
        }
    }
}
