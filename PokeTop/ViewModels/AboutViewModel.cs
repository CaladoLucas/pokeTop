using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace PokeTop.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Sobre o App";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://google.com")));
            
        }

        public ICommand OpenWebCommand { get; }



    }
}