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
    public partial class EditQuestionsById : ContentPage
    {
        public ObservableCollection<GetAllQuestionsClass> detail { get; set; } = new ObservableCollection<GetAllQuestionsClass>();
        public GetAllQuestionsClass c;
        public EditQuestionsById()
        {
            InitializeComponent();
            BindingContext = new CreateQuestionPage();

            MessagingCenter.Subscribe<CreateQuestionPage, GetAllQuestionsClass>(this, "Good", (s, a) =>
            {
                c=a;
                using (SQLiteConnection database = new SQLiteConnection(App.FilePath))
                {
                    database.CreateTable<GetAllQuestionsClass>();
                    int x = database.Insert(c);
                    detail.Add(c);
                }
             
            });
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = SearchItem.Text;
            var result = detail.Where(c=>Convert.ToString(c.Id).Contains(keyword));
            lists.ItemsSource = result;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection database = new SQLiteConnection(App.FilePath))
            {
                database.CreateTable<GetAllQuestionsClass>();
                var data = database.Table<GetAllQuestionsClass>().ToList();
                detail = new ObservableCollection<GetAllQuestionsClass>(data);

                lists.ItemsSource = detail;
            };
        }
    }
}