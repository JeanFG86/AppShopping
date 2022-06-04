﻿using AppShopping.Libraries.Enums;
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
    public class StoresViewModel : EstablishmentViewModel
    {
        public StoresViewModel(EstablishmentType establishmentType) : base(establishmentType)
        {
        }
    }
}
