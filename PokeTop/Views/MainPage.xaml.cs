using PokeTop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokeTop.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : MasterDetailPage
    {
        NavigationPage browser = new NavigationPage(new ItemsPage());
        NavigationPage about = new NavigationPage(new AboutPage());
        public MainPage()
        {
            InitializeComponent();
            
            MasterBehavior = MasterBehavior.Popover;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Detail = browser;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            this.Detail = about;
        }
    }
}