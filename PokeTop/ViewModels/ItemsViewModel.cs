using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Net.Http;
using System.Collections.Generic;
using PokeTop.Models;
using PokeTop.Views;
using Newtonsoft.Json.Linq;

namespace PokeTop.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Pokemons> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        HttpClient client = new HttpClient();
        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<Pokemons>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
           
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var response = await client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/?limit=151");
                var obj = JObject.Parse(response);
                var result = obj["results"].ToString();

                var items = JsonConvert.DeserializeObject<List<Pokemons>>(result);
                
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}