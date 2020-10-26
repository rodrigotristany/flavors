using System;
using System.IO;
using System.Reflection;
using flavors.AppLayer.Environments;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace flavors
{
    public partial class App : Application
    {
        private MainPage mainPage;

        public App()
        {
            InitializeComponent();
            mainPage = new MainPage();
            MainPage = new NavigationPage(mainPage);
        }

        protected override void OnStart()
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("flavors.AppLayer.Environments.environments.json");

            string text = "";
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            Environments env = JsonConvert.DeserializeObject<Environments>(text);

#if __QA__
            Environments.Current = env.Qa;
#elif __PROD__
            Environments.Current = env.Prod;
#else
            Environments.Current = env.Dev;
#endif

            mainPage.Title = Environments.Current.PageTitle;
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
