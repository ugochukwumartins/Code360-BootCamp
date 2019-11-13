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
    public partial class MasterPagesAll : MasterDetailPage
    {
        private List<Pages> Allpage;
        public MasterPagesAll()
        {
            InitializeComponent();
            Allpage = new List<Pages>()
            {
                new Pages{ Title= "DashBoard", Icon="", TypeOf= typeof(DashBoard)},
               new Pages{ Title= "Instructor", Icon="", TypeOf= typeof(InstructorTapedPage)},
              //  new Pages{ Title= "Students", Icon="", TypeOf= typeof(CreateQuestionPage)},
                new Pages{ Title= "Courses", Icon="", TypeOf= typeof(MasterDetailOfCourses)},
             
                new Pages{ Title= "Settings", Icon="", TypeOf= typeof(SettingsPage)},

                   new Pages{ Title= "Questions", Icon="", TypeOf= typeof(QuestionTapPage)},
            };
            lists.ItemsSource = Allpage;
           // listss.ItemsSource = Allpage;
        }

        private void lists_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Pages;
            Type page = item.TypeOf;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;

        }
        protected override bool OnBackButtonPressed()
        {
            return false;
        }
    }
}