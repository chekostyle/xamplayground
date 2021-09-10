using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Test
{
    public partial class MainPage : ContentPage
    {
        public ICommand ChangeTitleColorCommand { get; private set; }
        public ICommand ChangeTitleTextColorCommand { get; private set; }

        private NavigationPage navigationPage;
        public MainPage()
        {
            InitializeComponent();
            
            Title = "This is the title";
            ChangeTitleColorCommand = new Command<string>(OnChangeTitleColorCommand);
            ChangeTitleTextColorCommand = new Command<string>(OnChangeTitleTextColorCommand);
        }

        private void OnChangeTitleColorCommand(string obj)
        {
            navigationPage.BarBackgroundColor = Color.FromHex(obj);

        }

        private void OnChangeTitleTextColorCommand(string obj)
        {
            navigationPage.BarTextColor = Color.FromHex(obj);
        }

        protected override void OnAppearing()
        {
            navigationPage = (NavigationPage)Application.Current.MainPage;
        }

       
    }
}
