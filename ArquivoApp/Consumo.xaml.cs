using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
                listaArquivos.Add(nomearquivo);
            }
            listaArquivo.ItemsSource = listaArquivos;
        }
    }
}
