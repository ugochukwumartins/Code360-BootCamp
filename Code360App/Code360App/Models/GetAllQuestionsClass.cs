using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Code360App.Models
{
  
   public class GetAllQuestionsClass
    {
        private int id;
        private string option1;
        private string option2;
        private string option3;
        private string option4;
        private string answer;



      [JsonProperty("id")]
        public int Id {
            get { return id; }
            set { id= value; }
        }

        [JsonProperty("option1")]
        public string Option1 {
            get { return option1; }
            set { option1 = value; }
        }

        [JsonProperty("option2")]
        public string Option2
        {
            get { return option2; }
            set { option2 = value; }
        }

        [JsonProperty("option3")]
        public string Option3
        {
            get { return option3; }
            set { option3= value; }
        }

        [JsonProperty("option4")]
        public string Option4
        {
            get { return option4; }
            set { option4 = value; }
        }

        [JsonProperty("answer")]
        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }


    }
}
