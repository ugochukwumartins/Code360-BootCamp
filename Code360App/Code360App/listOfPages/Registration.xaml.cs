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
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
            BindingContext = new CreateQuestionPage();
            MessagingCenter.Subscribe<CreateQuestionPage, ObservableCollection<GetAllQuestionsClass>>(this,"ok", (s, a) =>
             {
                 lists.ItemsSource = a;
             });
        }

    }
}