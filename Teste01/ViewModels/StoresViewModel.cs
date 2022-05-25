using AppShopping.Libraries.Enums;
using AppShopping.Models;
using AppShopping.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace Teste01.ViewModels
{
    public class StoresViewModel
    {
        public string SearchWord { get; set; }
        public ICommand SearchCommand { get; set; }
        public List<Establishment> Establishments { get; set; }

        public StoresViewModel()
        {
            SearchCommand = new Command(Search);

            var allEstablishment = new EstablishmentService().GetEstablishment();
            var allStores = allEstablishment.Where(x => x.Type == EstablishmentType.Store).ToList();

            Establishments = allStores;
        }

        private void Search()
        {

        }
    }
}
