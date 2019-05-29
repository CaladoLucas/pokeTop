using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokeTop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start : ContentPage
    {
        public Start()
        {
            InitializeComponent();
        }

        private async void BtnIniciar_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(edtNome.Text))
            {
                await DisplayAlert("Alerta!", "Digite seu nome", "OK");
            }
            else
            {
                saveName(edtNome.Text);
                await Navigation.PushModalAsync(new MainPage());
            }

        }

        void saveName(String name)
        {
            Application.Current.Properties["nome"] = name;
            Application.Current.SavePropertiesAsync();
        }
    }
}