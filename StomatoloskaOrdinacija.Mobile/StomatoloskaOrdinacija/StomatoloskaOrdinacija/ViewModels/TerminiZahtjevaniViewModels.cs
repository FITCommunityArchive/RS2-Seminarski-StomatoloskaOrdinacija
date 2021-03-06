﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using StomatoloskaOrdinacija.Model;
using StomatoloskaOrdinacija.Model.Requests;
using Xamarin.Forms;

namespace StomatoloskaOrdinacija.ViewModels
{
    public class TerminiZahtjevaniViewModels
    {
        private readonly APIService _terminService = new APIService("Termin");

        public TerminiZahtjevaniViewModels()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Termin> TerminiList { get; set; } = new ObservableCollection<Termin>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            UserDialogs.Instance.ShowLoading("Učitavanje zahtjevanih termina..");
            var request = new TerminSearchRequest();
            request.IsNaCekanju = true;
            request.PacijentId = APIService.PacijentId;
            var list = await _terminService.GetAll<List<Model.Termin>>(request);

            TerminiList.Clear();
            foreach (var termin in list)
            {
                TerminiList.Add(termin);
            }
            UserDialogs.Instance.HideLoading();
        }
    }
}
