using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Code360App.Model_api
{
  public  class ListOfAllcoursesMain
    {
      

             [PrimaryKey]
        public int Id { get; set; }

      
       
        public string Titles
        {
            get;
            set;
        }

      
      
        public string Cost
        {
            get;
            set;
        }

      
        public string Duration
        {
            get;
            set;
        }

 
       
        public int InstructorsId
        {
            get ;
            set ;
        }
    }
}
