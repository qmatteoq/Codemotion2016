using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Platform;
using NewsReader.Android.Services;
using NewsReader.Shared.Services;

namespace NewsReader.Android
{
    public class Setup: MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Shared.App();
        }

        protected override void InitializeFirstChance()
        {
            Mvx.RegisterType<IDialogService, DialogService>();
            base.InitializeFirstChance();
        }
    }
}