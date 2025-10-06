using System;
using Xamarin.Forms;

namespace SmartSafetyStore.Mobile
{
    public class LoginPage : ContentPage
    {
        Entry emailEntry, passwordEntry;
        Button loginBtn;
        public LoginPage()
        {
            emailEntry = new Entry { Placeholder = "Email" };
            passwordEntry = new Entry { Placeholder = "Password", IsPassword = true };
            loginBtn = new Button { Text = "Login" };
            loginBtn.Clicked += LoginBtn_Clicked;
            Content = new StackLayout { Padding = 20, Children = { emailEntry, passwordEntry, loginBtn } };
        }

        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Demo","Login simulated","OK");
        }
    }
}
