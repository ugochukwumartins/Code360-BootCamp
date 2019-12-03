using Code360App.Models;
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
    public partial class DetailOfAllinstructor : ContentPage
    {
        public ObservableCollection<NewInstructors> loginModels { get; set; } = new ObservableCollection<NewInstructors>();
     public   NewInstructors c;
        public DetailOfAllinstructor()
        {
            InitializeComponent();

            BindingContext = new NewInstructor();

            MessagingCenter.Subscribe<NewInstructor,NewInstructors>(this, "Send", (s, a) =>
             {
                 c = a;
                 using (SQLiteConnection database = new SQLiteConnection(App.FilePath))
                 {
                     database.CreateTable<NewInstructors>();
                     int x = database.Insert(c);
                     loginModels.Add(c);
                 }
               
               
             });
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection database = new SQLiteConnection(App.FilePath))
            {
                database.CreateTable<NewInstructors>();
                var data = database.Table<NewInstructors>().ToList();
                loginModels = new ObservableCollection<NewInstructors>(data);
                instructor.ItemsSource = loginModels;
            };
        }
    }
}