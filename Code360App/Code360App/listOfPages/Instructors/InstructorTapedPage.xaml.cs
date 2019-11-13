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
    public partial class InstructorTapedPage : TabbedPage
    {
        public InstructorTapedPage()
        {
            InitializeComponent();
        }
    }
}