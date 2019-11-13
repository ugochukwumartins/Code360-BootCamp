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
    public partial class GetAllQuestions : ContentPage
    {
        public ObservableCollection<GetAllQuestionsClass> detail { get; set; } = new ObservableCollection<GetAllQuestionsClass>();
        public GetAllQuestions()
        {
            InitializeComponent();
            BindingContext = new CreateQuestionPage();

            MessagingCenter.Subscribe< CreateQuestionPage, GetAllQuestionsClass >(this, "Good", (s, a) =>
            {
                detail.Add(a);
                lists.ItemsSource = detail;
            });
        }
    }
}