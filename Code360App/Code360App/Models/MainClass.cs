using Code360App.listOfPages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Code360App.Models
{
    class MainClass
    {
        private INavigation Navigation;
        private INavigation Navigations;
        public MainClass( INavigation Register)
        {
            Navigation = Register;
            Navigations = Register;
        }
        public ICommand commands => new Command(Send);
        public void Send()
        {
            Navigation.PushAsync(new LoginPage());
        }

        public ICommand command => new Command(Sends);

        public void Sends()
        {
            Navigations.PushAsync(new Registration());
        }
    }
}
