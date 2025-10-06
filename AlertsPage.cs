using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace SmartSafetyStore.Mobile
{
    public class AlertsPage : ContentPage
    {
        ObservableCollection<string> alerts = new ObservableCollection<string>();
        public AlertsPage()
        {
            var list = new ListView { ItemsSource = alerts };
            Content = new StackLayout { Children = { new Label{ Text="Alerts" }, list } };
            alerts.Add("Sensor BOX_1: item removed (demo)");
        }
    }
}
