using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamlasXML
{
    public class SellableItem
    {
            public Color ImageUri { get; set; }
            public String Title { get; set; }
            public String Price { get; set; }

            public override string ToString()
            {
                return $"We sell {Title} of color {ImageUri} Damilare";
            }
        }
    }
