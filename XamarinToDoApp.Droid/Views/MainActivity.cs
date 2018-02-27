using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Views.InputMethods;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views.Attributes;
using XamarinToDoApp.Core.ViewModels;

namespace XamarinToDoApp.Droid
{  
    [MvxActivityPresentation]
    [Activity(Label = "MainView", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainView : MvxAppCompatActivity<MainViewModel>
    {
        public DrawerLayout DrawerLayout { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainView);

            //Button button1 = FindViewById<Button>(Resource.Id.button1);
            //button1.Click += Button1_Click;

            if (savedInstanceState == null)
            {
                ViewModel.ShowFragment();
            }

        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    SetContentView(Resource.Layout.ToDoList);
        //}
    }
}

