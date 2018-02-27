using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Views;
using MvvmCross.Droid.Views;
using MvvmCross.Binding.Droid.Views;
using MvvmCross.Binding.Droid.BindingContext;
using XamarinToDoApp.Core.ViewModels;
using XamarinToDoApp.Droid.Adapters;

namespace XamarinToDoApp.Droid
{
    [Activity(Label = "XamarinToDoApp", MainLauncher = true)]
    public class MainActivity : MvxActivity<MainViewModel>
    {
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            //Button button1 = FindViewById<Button>(Resource.Id.button1);
            //button1.Click += Button1_Click;
            var listView = FindViewById<MvxListView>(Resource.Id.listView);
            listView.Adapter = new BaseListAdapter(this, (IMvxAndroidBindingContext)BindingContext);
        }

        //protected override void OnListItemClick(ListView l, View v, int position, long id)
        //{
        //    var t = items[position];
        //    Android.Widget.Toast.MakeText(this, t, Android.Widget.ToastLength.Short).Show();
        //}

        private void Button1_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.ToDoList);
        }
    }
}

