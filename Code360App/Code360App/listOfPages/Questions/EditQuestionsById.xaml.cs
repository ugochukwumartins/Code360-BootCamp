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

        private void lists_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var db = e.SelectedItem as GetAllQuestionsClass;
           Option1.Text = db.Option1;   Option2.Text = db.Option2;  Option3.Text = db.Option3;
            Option4.Text = db.Option4;  answer.Text = db.Answer;   ids.Text = Convert.ToString(db.Id);    question.Text = db.Questions;
            
    }

        private void Button_Clicked(object sender, EventArgs e)
        {
            GetAllQuestionsClass bm = detail.FirstOrDefault(c => c.Id == Convert.ToInt32(ids.Text));

           bm.Option1 = Option1.Text; bm.Option2= Option2.Text; bm.Option3= Option3.Text;
             bm.Option4 = Option4.Text; bm.Answer= answer.Text; bm.Id= Convert.ToInt32( ids.Text); bm.Questions= question.Text;

            var dbsource = new SQLiteConnection(App.FilePath);
            dbsource.Update(bm);
            detail.Add(bm);
            lists.ItemsSource = detail;
        }
    }
}