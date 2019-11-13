using Code360App.Model_api;
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
    public partial class CreatingCourses : ContentPage
    {
     
        public CreatingCourses()
        {
            InitializeComponent();
         
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            var listOfAllcoursesMain = new ListOfAllcoursesMain
            {
                Cost = cost.Text,
                Duration = duration.Text,
                InstructorsId =Convert.ToInt32( instructorsId.Text),
                Titles = title.Text
            };
           
            MessagingCenter.Send(this, "AddItem", listOfAllcoursesMain);
            Navigation.PopModalAsync();
       
        }

    }
}