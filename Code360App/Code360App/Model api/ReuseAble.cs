using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Code360App.Model_api
{
public class ReuseAble : INotifyPropertyChanged
    {
        public IDataStore<ListOfAllcoursesMain> DataStore => DependencyService.Get<IDataStore<ListOfAllcoursesMain>>();

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string x = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(x));
        }
    }
    
    
}
