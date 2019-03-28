using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ArquivoApp
{
    public partial class Consumo : ContentPage
    {
      
        public Consumo()
        {
            InitializeComponent();
            label_secundario.Text = App.ValorDesteContexto;
        }
    }
}
