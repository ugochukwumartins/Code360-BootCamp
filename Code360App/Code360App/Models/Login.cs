using Code360App.listOfPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Code360App.Models
{
    class Login
    {
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
        public void Sends()
        {
            if (username != null && username != "" && username.Length >=6) {
                if (password != null && password != "" && password.Length >=6) {
                    Application.Current.MainPage.DisplayAlert(null, "successful", "ok");
                    Navigation.PushAsync(new MasterPagesAll());
                    username = null;
                    password = null;
                }
            }
        }
    }
}
