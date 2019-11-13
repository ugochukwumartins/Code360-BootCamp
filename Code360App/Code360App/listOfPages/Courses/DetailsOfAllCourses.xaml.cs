using Code360App.Model_api;
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
    public partial class DetailsOfAllCourses : ContentPage
    {
        public ObservableCollection<ListOfAllcoursesMain> loginModels { get; set; } = new ObservableCollection<ListOfAllcoursesMain>();
        public DetailsOfAllCourses()
        {
            InitializeComponent();
            BindingContext = new CreatingCourses();

            MessagingCenter.Subscribe<CreatingCourses, ListOfAllcoursesMain>(this, "AddItem", (s, a) =>
            {
                loginModels.Add(a);
                detailslist.ItemsSource = loginModels;
            });
        }
    }
}