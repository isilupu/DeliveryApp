﻿using DeliveryApp.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DeliveryApp.ViewModels
{
    public class MenuItemViewModel
    {
        #region Attributes
        public NavigationService navigationService;
        #endregion

        #region Properties
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }
        #endregion

        #region Constructors
        public MenuItemViewModel() 
        {
            navigationService = new NavigationService();
        }
        #endregion


        #region Comandos
        public ICommand NavigateCommand { get { return new RelayCommand(Navigate); } }

        private async void Navigate()
        {
            await navigationService.Navigate(PageName);
        }
        #endregion
    }
}
