using Code360App.Models;
using System;
using System.Collections.Generic;
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
      
        public SettingsPage()
        {
            InitializeComponent();
          
            QuestionP.Items.Add("10");
            QuestionP.Items.Add("20");
            QuestionP.Items.Add("30");
            QuestionP.Items.Add("40");
            QuestionP.Items.Add("50");
        }
    }
}