using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;

namespace ArquivoApp
{
    public partial class Consumo : ContentPage
    {
        ArrayList listaArquivos = new ArrayList();
        public Consumo()
        {
            InitializeComponent();
            //listaArquivo.ItemsSource = lista;
        }

        protected override void OnAppearing()
        {
            var arquivos = Directory.EnumerateFiles(App.PastaDiretorio, "*.txt");
            foreach(var nomearquivo in arquivos)
            {
                int indice = nomearquivo.LastIndexOf('/');
                listaArquivos.Add(nomearquivo.Substring(indice + 1));
            }
            listaArquivo.ItemsSource = listaArquivos;
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {

            //var valor = sender;
            //var eh = e;
            await DisplayAlert("Titulo", e.SelectedItem.ToString(), "OK");
        }
    }
}
