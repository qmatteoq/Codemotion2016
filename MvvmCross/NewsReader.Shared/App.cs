using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using NewsReader.Shared.Services;
using NewsReader.Shared.ViewModels;

namespace NewsReader.Shared
{
    public class App: MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<IRssService, RssService>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<MainViewModel>());
        }
    }
}
