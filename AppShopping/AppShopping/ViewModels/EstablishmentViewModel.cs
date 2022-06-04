using AppShopping.Libraries.Enums;
using AppShopping.Libraries.Helpers.mvvm;
using AppShopping.Models;
using AppShopping.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppShopping.ViewModels
{
    public abstract class EstablishmentViewModel : BaseViewModel
    {
        public string SearchWord { get; set; }
        public ICommand SearchCommand { get; set; }

        private List<Establishment> _establishments;

        public List<Establishment> Establishments
        {
            get { return _establishments; }
            set { SetProperty(ref _establishments, value); }
        }


        //public List<Establishment> Establishments { get; set; }
        public List<Establishment> _allEstablishment { get; set; }

        public ICommand DetailCommand { get; set; }

        private readonly EstablishmentType _establishmentType;

        public EstablishmentViewModel(EstablishmentType establishmentType)
        {
            _establishmentType = establishmentType;
            SearchCommand = new Command(Search);
            DetailCommand = new Command<Establishment>(Detail);

            var allEstablishment = new EstablishmentService().GetEstablishment();
            var allStores = allEstablishment.Where(x => x.Type == _establishmentType).ToList();

            Establishments = allStores;
            _allEstablishment = allStores;
        }

        private void Detail(Establishment establishment)
        {
            String establishmentSerialized = JsonConvert.SerializeObject(establishment);
            Shell.Current.GoToAsync($"establishment/detail?establishmentSerialized={Uri.EscapeDataString(establishmentSerialized)}");
        }

        private void Search()
        {
            Establishments = _allEstablishment.Where(x => x.Name.ToLower().Contains(SearchWord.ToLower())).ToList();
        }
    }
}
