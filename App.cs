using Xamarin.Forms;
namespace SmartSafetyStore.Mobile
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
