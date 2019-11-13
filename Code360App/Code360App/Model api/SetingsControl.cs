using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Code360App.Model_api
{
    class SetingsControl
    {
        [JsonProperty("id")]
        [PrimaryKey,AutoIncrement]
        public long Id { get; set; }

        [JsonProperty("testPassPercentage")]
        public int TestPassPercentage { get; set; }

        [JsonProperty("testTolerancePercentage")]
        public long TestTolerancePercentage { get; set; }

        [JsonProperty("questionsNumber")]
        public int QuestionsNumber { get; set; }

        [JsonProperty("preworkDate")]
        public string PreworkDate { get; set; }

        [JsonProperty("performancePercentage")]
        public long PerformancePercentage { get; set; }

     //   public ICommand commands => new Command(Sends);

       // public async void Sends()
       // {

       // }
    }
}
