using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlasXML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewsTest : ContentPage
    {
        public List<SellableItem> Stock { get; set; } = new List<SellableItem>();
        public ListViewsTest()
        {
            InitializeComponent();
            Stock = new List<SellableItem> { new SellableItem { Title = "One", Price = "20.00", ImageUri = Color.Red }, new SellableItem { Title = "Two", Price = "40.00", ImageUri = Color.Green }, new SellableItem { Title = "Three", Price = "60.00" }, new SellableItem { Title = "Four", Price = "80.00", ImageUri = Color.Purple }, new SellableItem { Title = "One", Price = "20.00", ImageUri = Color.Black }, new SellableItem { Title = "Two", Price = "40.00", ImageUri = Color.Green } };

            //stockList.ItemsSource = Stock;
            List<Color> colors = new List<Color> { Color.Accent, Color.Aquamarine, Color.Blue, Color.CadetBlue, Color.Coral, Color.Chartreuse, Color.Cyan };
            
            secondOne.ItemsSource = colors;
            secondTwo.ItemsSource = Stock;

        }
    }
}