using DeliveryApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryApp.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator() {

            Main = new MainViewModel();
        }
    }
}
