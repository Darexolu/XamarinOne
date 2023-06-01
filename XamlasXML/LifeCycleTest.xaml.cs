using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlasXML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LifeCycleTest : ContentPage
    {
        public LifeCycleTest()
        {
            InitializeComponent();
            //currentApp = Application.Current;
            //entryy.Text = (currentApp.Properties["entryContent"] ?? String.Empty) as String;
            //label.Text = (currentApp.Properties["labelContent"] ?? String.Empty) as String;
           
        }
        //private Application currentApp;
        //private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    Entry entry = sender as Entry;
        //    String oldText = e.OldTextValue ?? String.Empty;
        //    String oldTextFormatted = e.OldTextValue == null ? string.Empty : $"from \n {oldText} \n";
        //    String newText = e.NewTextValue ?? String.Empty;
        //    label.Text = $"Text changed {oldTextFormatted} to \n{newText}";
        //    currentApp.Properties["entryContent"] = entry.Text;
        //    currentApp.Properties["labelContent"] = label.Text;
        //}

        ////private void Button_Clicked()
        ////{
        //    if (loremipsum.MaxLines == 200) loremipsum.MaxLines = 1;
        //    else
        //        loremipsum.MaxLines = 200;

        ////}
        ///

        private void ONCLICK(object sender, EventArgs e)
        {
            if (loremipsum.MaxLines == -1) loremipsum.MaxLines = 1;
            else
                loremipsum.MaxLines = -1;

        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            //label2.Text = e.NewTextValue;
            loremipsum.Text = e.NewTextValue;
        }

        private void PeterDidTHis_Tapped(object sender, EventArgs e)
        {
            ContentViews wetinWeDeyFind = sender as ContentViews;
            String peter = wetinWeDeyFind.Peter;
            String abk = wetinWeDeyFind.AbdulKadir;
            var howWeGotHere = "Peter lead us here";
            wetinWeDeyFind.Damilare = howWeGotHere;
        }
    }
}