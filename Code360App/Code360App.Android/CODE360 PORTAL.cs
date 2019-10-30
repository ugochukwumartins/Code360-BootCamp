﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Code360App.Droid
{
    [Activity(Label = "CODE360_PORTAL",
        Theme = "@style/Theme.Splash",
        MainLauncher = true,
        NoHistory = true
        )]
    public class CODE360_PORTAL : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            StartActivity(typeof(MainActivity));
        }
    }
}