using MvvmCross.Platform.IoC;
using XamarinToDoApp.Core.ViewModels;

namespace XamarinToDoApp.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            
            RegisterNavigationServiceAppStart<MainViewModel>();
        }
    }
}
