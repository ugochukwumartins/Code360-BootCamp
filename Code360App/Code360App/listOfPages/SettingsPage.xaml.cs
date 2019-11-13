using Code360App.Model_api;
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
    public partial class SettingsPage : ContentPage
    {

        ObservableCollection<SetingsControl> Allitem;
        public SettingsPage()
        {
            InitializeComponent();
            BindingContext = new SetingsControl();


        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection database = new SQLiteConnection(App.FilePath))
            {
                database.CreateTable<SetingsControl>();
                //datab.Insert(Dayly);
                var data = database.Table<SetingsControl>().ToList();
                Allitem = new ObservableCollection<SetingsControl>(data);
                setinglist.ItemsSource = Allitem;
            }
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
           var sett =  new SetingsControl(){
                TestPassPercentage = Convert.ToInt32(TestMark.Text),
      TestTolerancePercentage= Convert.ToInt32(Tolerance.Text),
      PreworkDate= DateT.Date.ToString(),
      QuestionsNumber= Convert.ToInt32(Questons.Text),
      PerformancePercentage= Convert.ToInt32(PerformancePercent.Text)
            };
            using (SQLiteConnection database = new SQLiteConnection(App.FilePath))
            {
              database.CreateTable<SetingsControl>();


              int x = database.Insert(sett);

                Allitem.Add(sett);
               // setinglist.ItemsSource = sett;

            }

           
          //  setinglist.ItemsSource = Allitem;
        }
    }
}