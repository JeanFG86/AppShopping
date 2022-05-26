﻿using AppShopping.Libraries.Enums;
using AppShopping.Libraries.Helpers.mvvm;
using AppShopping.Models;
using AppShopping.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppShopping.ViewModels
{
    public class StoresViewModel : BaseViewModel
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

        public StoresViewModel()
        {
            SearchCommand = new Command(Search);

            var allEstablishment = new EstablishmentService().GetEstablishment();
            var allStores = allEstablishment.Where(x => x.Type == EstablishmentType.Store).ToList();

            Establishments = allStores;
            _allEstablishment = allStores;
        }

        private void Search()
        {
            Establishments = _allEstablishment.Where(x => x.Name.ToLower().Contains(SearchWord.ToLower())).ToList();
        }
    }
}
