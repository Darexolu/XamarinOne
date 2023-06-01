using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlasXML
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContentViews : ContentView
	{
        public String Peter { get; set; }
        public String Damilare { get; set; }
        public String Ebuka { get; set; }
        public String AbdulKadir { get; set; }
        public String EbukaHidden { get; set; }
        public String AbdulKadirHidden { get; set; }
        public bool AskMe { get => askMe.IsToggled; set { askMe.IsToggled = value; } }
        public String AskMeTest { get => askMeText.Text; set { askMeText.Text = value; } }
        public ContentViews ()
		{
			InitializeComponent ();
		}
	}
}