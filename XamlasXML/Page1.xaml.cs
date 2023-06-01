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
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
			var head = titleHeader;
			head.Text = "Morning Xamil from code behind";
			head.FontSize = 42;
			head.BackgroundColor = Color.FromRgb(234, 234, 109);
	
		}
		private int  counter = 0;
		private void ClickMe_Clicked(object sender, EventArgs e)
		{
			clickMeDisplay.Text = $"Click me clicked{++counter%8} times(s) while {counter} in total";

        }
        private void ClickMe2_Clicked(object sender, EventArgs e)
        {
            if (sender is Button) entry.HeightRequest = entry.HeightRequest + 56;
            //var button = sender;
            Button thisButton = sender as Button;
            //if (thisButton.TextColor == Color.Red)
            //{
            //    thisButton.TextColor = Color.Yellow;
            //}
            //else
            //{
            //    thisButton.TextColor = Color.Red;
            //}


            List<Color> colors = new List<Color> { Color.Red, Color.Black, Color.Green, Color.Brown, Color.Orange, Color.Pink, Color.Blue, Color.Purple, Color.Yellow };
        int colorIndex = colors.IndexOf(thisButton.TextColor);
        int nextColorIndex = (colorIndex + 1) % colors.Count();
        thisButton.TextColor = colors[nextColorIndex];
            //button.text
            //button = new 
            switch_Toggled(new { }, new ToggledEventArgs(false));
        }


    private void switch_Toggled(object sender, ToggledEventArgs e)
{
    entry.Text = (entry.Text ?? "String.Empty") + $"\n and triggered from Switch";
}

private void label_TextChanged(object sender, TextChangedEventArgs e)
{

}

private void entry_SizeChanged(object sender, EventArgs e)
{

}

    }
}

	
