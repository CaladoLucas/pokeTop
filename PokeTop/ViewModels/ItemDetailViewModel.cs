using System;

using PokeTop.Models;

namespace PokeTop.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Pokemons Pokemon { get; set; }
        public ItemDetailViewModel(Pokemons item = null)
        {
            Title = item?.name;
            Pokemon = item;
        }
    }
}
