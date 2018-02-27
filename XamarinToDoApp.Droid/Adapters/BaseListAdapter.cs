using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Binding.Droid.Views;

namespace XamarinToDoApp.Droid.Adapters
{
    public class BaseListAdapter : MvxAdapter
    {
        public BaseListAdapter(Context context, IMvxAndroidBindingContext bindingContext) : base(context, bindingContext)
        {

        }
    }
}