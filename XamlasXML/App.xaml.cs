using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlasXML
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListViewsTest();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            //Application.Current.SavePropertiesAsync();
            //LifeCycleTest lifecycletest = new LifeCycleTest();
            //lifecycletest.entryy.Text = (Application.Current.Properties["entryContent"] ?? String.Empty) as String;
            //lifecycletest.label.Text = (Application.Current.Properties["labelContent"] ?? String.Empty) as String;

        }

        protected override void OnResume()
        {
        }
    }
}
