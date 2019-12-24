using Code360App.Model_api;
using SQLite;
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

      //  public ListOfAllcoursesMain c;
        public DetailsOfAllCourses()
        {
            InitializeComponent();
          //  BindingContext = new CreatingCourses();

            //MessagingCenter.Subscribe<CreatingCourses, ListOfAllcoursesMain>(this, "AddItem", (s, a) =>
            //{
            // //   c = a;
            //    using (SQLiteConnection database = new SQLiteConnection(App.FilePath))
            //    {
            //        database.CreateTable<ListOfAllcoursesMain>();
            //        int x = database.Insert(a);
            //        loginModels.Add(a);
            //      //  detailslist.ItemsSource = loginModels;
            //    }
            //});
         


        }
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    using (SQLiteConnection database = new SQLiteConnection(App.FilePath))
        //    {
        //        database.CreateTable<ListOfAllcoursesMain>();
        //        var data = database.Table<ListOfAllcoursesMain>().ToList();
        //        loginModels = new ObservableCollection<ListOfAllcoursesMain>(data);
               
        //        detailslist.ItemsSource = loginModels;
        //    };
        //}
    }
}