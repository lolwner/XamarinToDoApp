using System;
using Android.Content.Res;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.AppCompat;
namespace XamarinToDoApp.Droid.Views.Fragments
{
    public abstract class BaseFragment : MvxFragment
    {
        private MvxActionBarDrawerToggle _drawerToggle;

        public MvxAppCompatActivity ParentActivity
        {
            get
            {
                return (MvxAppCompatActivity)Activity;
            }
        }

        protected BaseFragment()
        {
            RetainInstance = true;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);
            var view = this.BindingInflate(FragmentId, null);
            return view;
        }

        protected abstract int FragmentId { get; }

     
    }

    public abstract class BaseFragment<TViewModel> : BaseFragment where TViewModel : class, IMvxViewModel
    {
        public new TViewModel ViewModel
        {
            get { return (TViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }
    }
}