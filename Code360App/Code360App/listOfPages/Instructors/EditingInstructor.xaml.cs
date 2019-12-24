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
    public partial class EditingInstructor : ContentPage
    {
        public ObservableCollection<NewInstructors> loginModels { get; set; } = new ObservableCollection<NewInstructors>();
        public NewInstructors c;
        public EditingInstructor()
        {
            InitializeComponent();
            BindingContext = new NewInstructor();

            MessagingCenter.Subscribe<NewInstructor, NewInstructors>(this, "Send", (s, a) =>
            {
                c=a;
                using (SQLiteConnection database = new SQLiteConnection(App.FilePath))
                {
                    database.CreateTable<NewInstructors>();
                    int x = database.Insert(c);
                    loginModels.Add(c);
                }
            
            });
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = SearchItem.Text;
            var result = loginModels.Where(c => Convert.ToString(c.Id).Contains(keyword));
            instructor.ItemsSource = result;
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

        private void instructor_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
          var c=  e.SelectedItem as NewInstructors;
            name.Text = c.Name;
           email.Text = c.Email;
           password.Text = c.Password;
         ids.Text = Convert.ToString(c.Id);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            NewInstructors bm= loginModels.FirstOrDefault(c => c.Id == Convert.ToInt32(ids.Text));
            bm.Name = name.Text;
            bm.Email = email.Text;
            bm.Password = password.Text;
         
            var database = new SQLiteConnection(App.FilePath);
            database.Update(bm);
            loginModels.Add(bm);
            instructor.ItemsSource = loginModels;
        }
    }
}