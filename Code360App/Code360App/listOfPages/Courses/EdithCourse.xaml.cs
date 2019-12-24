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
    public partial class EdithCourse : ContentPage
    {
     
        public ObservableCollection<ListOfAllcoursesMain> loginModels { get; set; } = new ObservableCollection<ListOfAllcoursesMain>();
        SQLiteConnection bms;

      //  public ListOfAllcoursesMain c;
        public EdithCourse()
        {
            InitializeComponent();
            BindingContext = new CreatingCourses();

            MessagingCenter.Subscribe<CreatingCourses, ListOfAllcoursesMain>(this, "AddItem", (s, a) =>
            {
              //  c=a;
             
                using (SQLiteConnection database = new SQLiteConnection(App.FilePath))
                {
                   
                
                    database.CreateTable<ListOfAllcoursesMain>();
                
                    int x = database.Insert(a);
                    loginModels.Add(a);
                    detailslist.ItemsSource = loginModels;
                }
            });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection database = new SQLiteConnection(App.FilePath))
            {
                database.CreateTable<ListOfAllcoursesMain>();
                var data = database.Table<ListOfAllcoursesMain>().ToList();
                loginModels = new ObservableCollection<ListOfAllcoursesMain>(data);

                detailslist.ItemsSource = loginModels;
            };
        }


        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = SearchItem.Text;  
            var result = loginModels.Where(c=>Convert.ToString(c.Id).Contains(keyword));
            detailslist.ItemsSource = result;
        }

        private void detailslist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
         var c=   e.SelectedItem as ListOfAllcoursesMain;



            
                 title.Text = c.Titles;
                instructorsId.Text = Convert.ToString(c.InstructorsId);
                duration.Text = c.Duration;
                cost.Text = c.Cost;
            ids.Text = Convert.ToString(c.Id);
          
        }

        private void Edits_Clicked(object sender, EventArgs e)
        {
            //var c= sender as ListOfAllcoursesMain;
            //title.Text = c.Titles;
            //instructorsId.Text = Convert.ToString(c.InstructorsId);
            //duration.Text = c.Duration;
            //cost.Text = c.Cost;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ListOfAllcoursesMain bm = loginModels.FirstOrDefault(c => c.Id == Convert.ToInt32(ids.Text));

         bm.Titles=   title.Text;
         bm.InstructorsId= Convert.ToInt32(instructorsId.Text);
         bm.Duration=   duration.Text;
          bm.Cost=  cost.Text;
            var database = new SQLiteConnection(App.FilePath);



            database.Update(bm);
             
              //  int x = database.Insert(bm);
              
              loginModels.Add(bm);
                detailslist.ItemsSource = loginModels;
            
           // loginModels.Add(bm);
           // detailslist.ItemsSource = loginModels;
        }
    }
}