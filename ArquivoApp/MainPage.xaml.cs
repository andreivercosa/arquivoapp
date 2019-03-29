using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;

namespace ArquivoApp
{
    public partial class MainPage : ContentPage
    {
        List<string> listaNome = new List<string>();

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            string nome = Path.GetRandomFileName() + ".txt";
            string nomeArquivo = Path.Combine(App.PastaDiretorio, $"{nome}");
            File.Create(nomeArquivo);
            //label_inicial.Text = nomeArquivo;
            listaNome.Add(nomeArquivo);
        }

        public MainPage()
        {
            InitializeComponent();
            label_inicial.Text = "Adicionando..";
            editor_valor.Text = App.PastaDiretorio;
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Consumo());
        }

        void quebrarString(object sender, System.EventArgs e)
        {
            string quebrar = editor_valor.Text;
            string [] array = quebrar.Split('/');
            int tamanho = array.Count() - 1;
            label_inicial.Text = array[tamanho];
        }
    }
}
