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
	public partial class Pete1 : ContentPage
	{
        public Pete1()
        {
            InitializeComponent();
            Label label = new Label();
            var el = label.Margin;
            Thickness thickness = new Thickness(12);
            Thickness thickness2 = new Thickness(12, 10);
            // Thickness thickness3 = new Thickness(12, 15, 7);
            Thickness thickness4 = new Thickness(12, 23, 14, 5);
            Thickness thickness5 = new Thickness();
            var left = thickness5.Left;
            var horiz = label.HorizontalOptions;
            StackLayout stackLayout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {
                        Text = "StackLayout",
                        HorizontalOptions = LayoutOptions.Start
                    },
                    new Label
                    {
                        Text = "stacks its children",
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Label
                    {
                        Text = "vertically",
                        HorizontalOptions = LayoutOptions.End
                    },
                    new Label
                    {
                        Text = "by default,",
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Label
                    {
                        Text = "but horizontal placement",
                        HorizontalOptions = LayoutOptions.Start
                    },
                    new Label
                    {
                        Text = "can be controlled with",
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Label
                    {
                        Text = "the HorizontalOptions property.",
                        HorizontalOptions = LayoutOptions.End
                    },
                    new Label
                    {
                        Text = "An Expand option allows one or more children to occupy the an area within the remaining space of the StackLayout after it's been sized to the height of its parent.",
                        HorizontalOptions = LayoutOptions.End,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                    new StackLayout
                    {
                        Spacing = 0,
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Label
                            {
                                Text = "Stacking"
                            },
                            new Label
                            {
                                Text = "can also be",
                                HorizontalOptions = LayoutOptions.CenterAndExpand
                            },
                            new Label
                            {
                                Text = "horizontal"
                            }
                        }
                    }
                }
            };
            //MyProperty = 3;
            int num = MyProperty;
            foreach (View item in stackLayout.Children.ToList())
            {
                stackLayout2.Children.Add(item);
            }
            //SignupBtn.TextColor = Color.White;
            //SignupBtn.FontSize = 20;
            //SignupBtn.CornerRadius = 50;
        }
        int counter = 9;
        public int MyProperty => counter;
    }
}
