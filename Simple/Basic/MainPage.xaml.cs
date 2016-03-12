using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Basic
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnShowMessage(object sender, RoutedEventArgs e)
        {
            string message = $"Hello {UserName.Text}";
            Message.Text = message;
        }
    }
}
