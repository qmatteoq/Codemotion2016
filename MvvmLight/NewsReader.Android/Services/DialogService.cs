using System.Threading.Tasks;
using Android.App;
using GalaSoft.MvvmLight.Views;
using IDialogService = NewsReader.Shared.Services.IDialogService;

namespace NewsReader.Android.Services
{
    public class DialogService : Shared.Services.IDialogService
    {
        public async Task ShowDialogAsync(string message)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(ActivityBase.CurrentActivity);

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