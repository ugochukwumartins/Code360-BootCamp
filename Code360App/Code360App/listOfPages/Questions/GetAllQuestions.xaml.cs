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
    public partial class GetAllQuestions : ContentPage
    {
        public ObservableCollection<GetAllQuestionsClass> detail { get; set; } = new ObservableCollection<GetAllQuestionsClass>(); 
        public GetAllQuestionsClass c;

        public GetAllQuestions()
        {
            InitializeComponent();
            BindingContext = new CreateQuestionPage();

            MessagingCenter.Subscribe< CreateQuestionPage, GetAllQuestionsClass >(this, "Good", (s, a) =>
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