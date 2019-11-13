using Code360App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Code360App.listOfPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailOfAllinstructor : ContentPage
    {
        public ObservableCollection<NewInstructors> loginModels { get; set; } = new ObservableCollection<NewInstructors>();
        public DetailOfAllinstructor()
        {
            InitializeComponent();

            BindingContext = new NewInstructor();

            MessagingCenter.Subscribe<NewInstructor,NewInstructors>(this, "Send", (s, a) =>
             {
                 loginModels.Add(a);
                 instructor.ItemsSource = loginModels;
             });
        }
    }
}