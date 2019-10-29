using Code360App.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Code360App.listOfPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateQuestionPage : ContentPage
    {
        // private const string Url = "https://jsonplaceholder.typicode.com/posts";
        // private HttpClient _client = new HttpClient();
        // public ObservableCollection<Post> detail;
        public ObservableCollection<GetAllQuestionsClass> detail = new ObservableCollection<GetAllQuestionsClass>();

        int id = 1;

        public CreateQuestionPage()
        {
            InitializeComponent();
            // BindingContext = new Post();
         
            BindingContext = new GetAllQuestions();
          
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var increase = id++;

            


            detail.Add(new GetAllQuestionsClass { Option1 = QuestionA.Text, Option2 = QuestionB.Text, Option3 = QuestionC.Text,
                Option4 = QuestionD.Text, Answer = Answer.Text, Id = increase });
           
            lists.ItemsSource = detail;
           MessagingCenter.Send(this,"ok", detail);
           
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {


        }
        //protected override async void OnAppearing()
        //{
        // var content= await _client.GetStringAsync(Url);
        //    var post = JsonConvert.DeserializeObject<List<Post>>(content);
        //    detail = new ObservableCollection<Post>(post);
        //    lists.ItemsSource = detail;

        //    base.OnAppearing();

        //}

        //private async void Add_Clicked(object sender, EventArgs e)
        //{
        //    var p = new Post {Id=id.Text, Title = title.Text, Body = body.Text};
        //    detail.Insert(0, p);
        //    var u = JsonConvert.SerializeObject(p);
        //   await _client.PostAsync(Url, new StringContent(u));

        //}

        //private async void Delete_Clicked_1(object sender, EventArgs e)
        //{
        //    var post = detail[0];
        //    detail.Remove(post);
        //   await _client.DeleteAsync(Url + "" +  post.Id);
        //}


    }
}