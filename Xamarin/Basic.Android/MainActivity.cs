using Android.App;
using Android.Widget;
using Android.OS;
using Basic.Android.ViewModels;
using Basic.Shared.ViewModels;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;

namespace Basic.Android
{
    [Activity(Label = "Basic.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ActivityBase
    {
        public MainViewModel ViewModel => ViewModelLocator.Main;

        private Binding _editTextBinding;
        private Binding _resultTextBinding;

        private Button _sayHelloButton;
        public Button SayHelloButton
            => _sayHelloButton ?? (_sayHelloButton = this.FindViewById<Button>(Resource.Id.SayHelloButton));

        private EditText _nameText;
        public EditText NameText => _nameText ?? (_nameText = this.FindViewById<EditText>(Resource.Id.NameText));

        private TextView _resultText;
        public TextView ResultText => _resultText ?? (_resultText = this.FindViewById<TextView>(Resource.Id.ResultText));

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _editTextBinding = this.SetBinding(() => ViewModel.Name, () => NameText.Text, BindingMode.TwoWay);
            _resultTextBinding = this.SetBinding(() => ViewModel.Message, () => ResultText.Text);
            SayHelloButton.SetCommand("Click", ViewModel.SayHello);
        }
    }
}

