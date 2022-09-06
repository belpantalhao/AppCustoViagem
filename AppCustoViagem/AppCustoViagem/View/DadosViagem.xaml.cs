using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCustoViagem.Model;

namespace AppCustoViagem.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DadosViagem : ContentPage
    {
        App PropriedadesApp;
        public DadosViagem()
        {
            InitializeComponent();
            
            PropriedadesApp = (App)Application.Current;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
          try
            {
                Navigation.PushAsync(new ListaPedagios());
            }catch(Exception ex)
            {
                DisplayAlert("Vish kk", ex.Message, "Beleza");
            }
        }

        private void Button_Add_Clicked(object sender, EventArgs e)
        {
          try 
            {
                PropriedadesApp.ArrayPedagios.Add(new Pedagio())
             {
               Id = PropriedadesApp.ArrayPedagios.Count + 1,
               Localizacao = txt_localizacao.Text,
               Valor = Convert.ToDouble(txt_preco_pedagio.Text.Replace(".", ","))
        });

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}