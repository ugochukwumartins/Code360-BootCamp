using Code360App.listOfPages;
using Code360App.Model_api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Code360App.Models
{

   public class Login
    {
    //  private const string Url = "http://unionfaith.westeurope.cloudapp.azure.com:3600/api/Account/Login";
    //  private HttpClient _client = new HttpClient();



        private string username;

        [JsonProperty("username")]
        [Required(ErrorMessage ="pkease complete the feild")]
        public string Username { get { return username; } set { username = value; } }



        private string password;
        [JsonProperty("password")]
        [Required(ErrorMessage = "pkease complete the feild")]
        [MaxLength(6)]
        public string Password { get { return password; } set { password = value; } }



        
        private INavigation Navigation;
        public Login(INavigation Login)
        {
            Navigation = Login;
    }
       public ICommand commands => new Command(Sends);
        public async void Sends()
        {
            
            // public ObservableCollection<Post> detail= new ObservableCollection<Post>();

            // var x=  new Post { Id = id.Text, Title = title.Text, Body = body.Text };
            //   de//  detail.Insert(0, p);
            // var u = JsonConvert.SerializeObject(p);
            // await _client.PostAsync(Url, new StringContent(u));

           
            if (username != null && username != "" && username.Length >=6) {
                if (password != null && password != "" && password.Length >=6) {
              //    var p = new LoginClassDetail { Username = username, Password = password };
               //  var x = JsonConvert.SerializeObject(p);
              //    var u = await _client.PostAsync(Url, new StringContent(x, Encoding.UTF8, "application/json");
             //     var bbb = u.StatusCode;
              //    if (u.IsSuccessStatusCode == true) { 
                    await Application.Current.MainPage.DisplayAlert(null, "successful", "ok");
                    await Navigation.PushAsync(new MasterPagesAll());
               //  }
              //    else
              //    {
              //       await Application.Current.MainPage.DisplayAlert(null, "unsuccessful", "ok");
              //    }
                    username = null;
                    password = null;
                }
            }
        }
    }
}
