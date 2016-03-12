using System.Threading.Tasks;

namespace NewsReader.Shared.Services
{
    public interface IDialogService
    {
        Task ShowDialogAsync(string message);
    }
}
