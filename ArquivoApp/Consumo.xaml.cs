using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ArquivoApp
{
    public partial class Consumo : ContentPage
    {
      
        public Consumo(List<string> lista)
        {
            InitializeComponent();
            label_secundario.Text = App.ValorDesteContexto;
        }
    }
}
