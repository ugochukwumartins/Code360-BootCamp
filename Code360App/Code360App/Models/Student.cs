using Code360App.listOfPages;
using Code360App.Model_api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Code360App.Models
{
    class Student
    {
        private int id;
        private int applicantId;
        private int coursesId;
        private string email;
        private string name;
        private string paymentType;
        private bool isLockedOut;



        [JsonProperty("id")]
        public int Id
        {
            get
            { return id; }
            set
            {
                id = value;
            }
        }

        [JsonProperty("applicantId")]
        public int ApplicantId
        {
            get
            { return applicantId; }
            set
            {
                applicantId = value;
            }
        }

        [JsonProperty("coursesId")]
        public int CoursesId
        {
            get
            { return coursesId; }
            set
            {
                coursesId = value;
            }
        }

        [JsonProperty("name")]
        public string Name
        {
            get
            { return name; }
            set
            {
                name= value;
            }
        }

    

        [JsonProperty("paymentType")]
        public string PaymentType
        {
            get
            { return paymentType; }
            set
            {
                paymentType = value;
            }
        }

        [JsonProperty("isLockedOut")]
        public bool IsLockedOut
        {
            get
            { return isLockedOut; }
            set
            {
                isLockedOut = value;
            }
        }

        [JsonProperty("email")]
      [Required]
        public string Email {
            get
            { return email; }
            set
            {
                email = value;
            }
        }

       

      

    //    private INavigation Navigation;
      

    //    public Student(INavigation send)
    //    {
    //        Navigation = send;
    //    }

    

    //   public ICommand command => new Command(Sends);

    //    public void Sends()
    //    {
    //        if(name != null && name != "" && name.Length >=6) {
    //            if (email != null && email != "") {
                    
    //                            if(isLockedOut) {
    //                                NewStudent registrationClass = new NewStudent()
    //                                {
                                     
    //                                    Email = email,
    //                                    IsLockedOut = isLockedOut,
    //                                    Name = name,
    //                                    PaymentType = paymentType
    //                        };
    //                    Application.Current.MainPage.DisplayAlert(null, "successful", "ok");
    //                        name = null;
    //                    email = null;
                                    
    //    }
    //    }
    //}
    //}
    }
}
