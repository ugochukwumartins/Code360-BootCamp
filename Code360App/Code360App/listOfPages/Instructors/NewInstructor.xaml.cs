using Code360App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Code360App.listOfPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewInstructor : ContentPage
    {
        int increase = 1;
        public NewInstructor()
        {
            InitializeComponent();
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            increase++;
            var instructor = new NewInstructors
            {
                Email = email.Text,
                Name = name.Text,
                Password = password.Text,
                 Id= increase


            };
            MessagingCenter.Send(this, "Send", instructor);
            Navigation.PopModalAsync();

        }
    }
}