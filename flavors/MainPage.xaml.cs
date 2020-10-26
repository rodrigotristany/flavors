using System.Net.Http;
using flavors.AppLayer.Environments;
using flavors.DataLayer.Api;
using Xamarin.Forms;

namespace flavors
{
    public partial class MainPage : ContentPage
    {
        private HttpClient httpClient;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
