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
            NavigationPage.SetHasBackButton(this, false);
            //listaArquivo.ItemsSource = lista;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
             Navigation.PushAsync(new MainPage());
        }

        protected override void OnAppearing()
        {
            var meuarquivo = new List<Arquivo>();

            var arquivos = Directory.EnumerateFiles(App.PastaDiretorio, "*.txt");
            foreach(var nomearquivo in arquivos)
            {
                //int indice = nomearquivo.LastIndexOf('/');
                //listaArquivos.Add(nomearquivo.Substring(indice + 1));
                //meuarquivo.Add(new Arquivo { Conteudo = "Test..." });
                //File.Delete(nomearquivo);
                meuarquivo.Add(new Arquivo {
                    Conteudo = File.ReadAllText(nomearquivo),
                    DtCriacao = File.GetCreationTime(nomearquivo).ToString()

                });
                }
            listaArquivo.ItemsSource = meuarquivo;
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            //var valor = sender;
            //var eh = e;

            bool delet = await DisplayAlert("Titulo", "Deletar" + e.ToString() + "?", "OK", "Cancelar");

            if (delet)
            {
            string nomeArq= Path.Combine(App.PastaDiretorio, $"{e.SelectedItem.ToString()}");
            File.Delete(nomeArq);
            App.listaNome.Add(nomeArq);
                //await Navigation.PopAsync();
                await Navigation.PushAsync(new Consumo());
            }
        }
    }
}
