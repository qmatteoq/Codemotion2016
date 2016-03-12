using System.Threading.Tasks;
using Android.App;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;
using NewsReader.Shared.Services;

namespace NewsReader.Android.Services
{
    public class DialogService : IDialogService
    {
        public async Task ShowDialogAsync(string message)
        {
            var top = Mvx.Resolve<IMvxAndroidCurrentTopActivity>();

            AlertDialog.Builder alert = new AlertDialog.Builder(top.Activity);

            alert.SetTitle(message);

            alert.SetPositiveButton("Ok", (senderAlert, args) =>
            {

            });

            alert.SetNegativeButton("Cancel", (senderAlert, args) =>
            {
            });
            alert.Show();

            await Task.Yield();
        }
    }
}