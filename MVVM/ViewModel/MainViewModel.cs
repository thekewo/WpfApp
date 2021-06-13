﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Core;

namespace WpfApp.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public HomeViewModel HomeVm { get; set; }
        public DiscoveryViewModel DiscoveryVm { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; } 
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            DiscoveryVm = new DiscoveryViewModel();

            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(r => 
            {
                CurrentView = HomeVm;
            });

            DiscoveryViewCommand = new RelayCommand(r =>
            {
                CurrentView = DiscoveryVm;
            });
        }
    }
}
