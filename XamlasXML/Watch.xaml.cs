using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlasXML
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Watch : ContentPage
	{
		public Watch ()
		{
			InitializeComponent ();
            //BindingContext = new WatchViewModel();

        }
        private bool allowTimer = true;
        private double mins;
        private double secs;
        double convertmins;
        double convertsec;
        double countdownTime;
        private void Start_Button(object sender, EventArgs e)
        {
           
            convertmins = double.Parse(entry1.Text ?? 0.ToString());
            convertsec = double.Parse(entry2.Text ?? 0.ToString());
            if(convertmins >= 0 && (convertsec >= 0 && convertsec <= 59)  )
            {
                mins = convertmins;
                secs = convertsec;
            }
            else
            {
                return;
            }
            
            countdownTime = (convertmins * 60) + convertsec;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                bool downCount = Countdowner();
               // if (convertmins.ToString().Length == 1 && convertsec.ToString().Length == 1)
                  //  {
                //        MyLabel.Text = $"0{Convert.ToInt32(convertmins)}: 0{Convert.ToInt32(convertsec)}";
                //    return true;
                //    }
                //    else if (convertmins.ToString().Length == 1 && convertsec.ToString().Length == 2) {
                //        MyLabel.Text = $"0{Convert.ToInt32(convertmins)}: {(Convert.ToInt32(convertsec))}";
                //    return true;

                //}
                //else
                //    {
                //       MyLabel.Text = $"{convertmins}:{convertsec}";
                    
                //    }    
                    (sender as Button).Text = (downCount) ? "Restart" : "Start";
                return downCount && allowTimer;

            });

        }
        //private void TimeController()
        //{
            
        //}
       
            bool Countdowner()
            {
                countdownTime--;
            if(convertsec > 0)
            {
                if (convertmins.ToString().Length == 1 && convertsec.ToString().Length == 1)
                      {
                            MyLabel.Text = $"0{Double.Parse(convertmins.ToString())}: 0{Double.Parse((--convertsec).ToString())}";
                       
                        }
                else if((convertmins.ToString().Length == 1 && convertsec.ToString().Length == 2))
                {
                    MyLabel.Text = $"0{Double.Parse(convertmins.ToString())}:{Double.Parse((--convertsec).ToString())}";

                }
                else
                {
                    MyLabel.Text = $"{convertmins.ToString()}:{(--convertsec).ToString()} ";

                }

                return true;
            }
            else if(convertsec == 0 && convertmins > 0)
            {
               convertsec = 60;

                if (convertmins.ToString().Length == 1 && convertsec.ToString().Length == 1)
                {
                    MyLabel.Text = $"0{Double.Parse((--convertmins).ToString())}: 0{Double.Parse((--convertsec).ToString())}";

                }
                else if ((convertmins.ToString().Length == 1 && convertsec.ToString().Length == 2))
                {
                    MyLabel.Text = $"0{Double.Parse((--convertmins).ToString())}:{Double.Parse((--convertsec).ToString())}";

                }
                else
                {
                    MyLabel.Text = $"{(--convertmins).ToString()}:{(--convertsec).ToString()} ";

                }
                return true;
            }
            return false;
                    
        }
            

       private void Button_Pause(object sender, EventArgs e)
        {

            var button = sender as Button;
            allowTimer = !allowTimer;
            if (allowTimer)
            {
                countdownTime = (mins * 60) * secs;
                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    bool downCount = Countdowner();
                    return downCount && allowTimer;
                });
            }
        }
    }
}