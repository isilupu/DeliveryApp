using DeliveryApp.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Services
{
    public class NavigationService
    {
        public async Task Navigate(string pageName) 
        {
            App.Master.IsPresented = false; // para que nos cierre nuestro menu lateral automaticamente
            
            switch (pageName) 
            {
                case "CustomersPage":
                    await App.Navigator.PushAsync(new CustomersPage());
                    break;
                case "DeliveriesPage":
                    await App.Navigator.PushAsync(new DeliveriesPage());
                    break;
                case "OrdersPage":
                    await App.Navigator.PushAsync(new OrdersPage());
                    break;
                case "ProductsPage":
                    await App.Navigator.PushAsync(new ProductsPage());
                    break;
                case "ConfigurationPage":
                    await App.Navigator.PushAsync(new ConfigurationPage());
                    break;
                case "SyncPage":
                    await App.Navigator.PushAsync(new SyncPage());
                    break;
                case "UserPage":
                    await App.Navigator.PushAsync(new UserPage());
                    break;
                default:
                    break;
            }
        }
    }

}
