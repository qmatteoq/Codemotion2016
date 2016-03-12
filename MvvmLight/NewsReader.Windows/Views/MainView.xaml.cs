using Windows.UI.Xaml.Controls;
using NewsReader.Shared.ViewModels;

namespace NewsReader.Windows.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainView : Page
    {
        public MainViewModel ViewModel { get; set; }

        public MainView()
        {
            this.InitializeComponent();
            ViewModel = this.DataContext as MainViewModel;
        }
    }
}
