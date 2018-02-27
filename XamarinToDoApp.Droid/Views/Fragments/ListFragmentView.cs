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
using MvvmCross.Droid.Views.Attributes;
using XamarinToDoApp.Core.ViewModels;
using XamarinToDoApp.Droid.Adapters;

namespace XamarinToDoApp.Droid.Views.Fragments
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("xamarinToDoApp.droid.views.fragments.ListFragmentView")]
    public class ListFragmentView : BaseFragment<ListFragmentViewModel>
    {
        protected override int FragmentId => Resource.Layout.ListFragmentViewLayout;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);
            var listView = view.FindViewById<MvxListView>(Resource.Id.listView);
            listView.Adapter = new BaseListAdapter(Activity, (IMvxAndroidBindingContext)BindingContext);

            return view;
        }
    }
}