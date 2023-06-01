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
    public partial class watchCorrection : ContentPage
    {
        public watchCorrection()
        {
            InitializeComponent();
        }
        private void Start_Clicked(object sender, EventArgs e)
        {
            mins = int.Parse(minutesEntry.Text ?? 0.ToString());
            secs = int.Parse(secondsEntry.Text ?? 0.ToString());
            if (!startStatus)
            {
                startStatus = true;
                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    bool timeIsStillReducable = ReduceTime();
                    (sender as Button).Text = timeIsStillReducable ? "Restart" : "Start";
                    timer.Text = $"{DigitDoubler(mins)} : {DigitDoubler(secs)}";
                    return timeIsStillReducable && allowTimer;
                });
            }
            else if (!allowTimer)
            {
                allowTimer = !allowTimer;
                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    bool timeIsStillReducable = ReduceTime();
                    //(sender as Button).Text = (timeIsStillReducable) ? "Restart" : "Start";
                    (sender as Button).Text = timeIsStillReducable ? "Restart" : "Start";
                    timer.Text = $"{DigitDoubler(mins)} : {DigitDoubler(secs)}";
                    return timeIsStillReducable && allowTimer;
                });
            }
           
            (sender as Button).Text = !allowTimer ? "Start" : "Restart";

        }

        private void TimerCOntroller()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                bool timeIsStillReducable = ReduceTime();
                timer.Text = $"{DigitDoubler(mins)} : {DigitDoubler(secs)}";
                return timeIsStillReducable && allowTimer;
            });
            //if (allowTimer ) return;

        }

        private String DigitDoubler(int numb) => numb > 9 ? numb.ToString() : "0" + numb;
        //{
        //    return 
        //}
        private void PauseClicked(object sender, EventArgs e)
        {
            allowTimer = !allowTimer;
            if (allowTimer) TimerCOntroller();
            (sender as Button).Text = allowTimer ? "Pause" : "Continue";
        }
        private bool startStatus = false;
        private bool allowTimer = true;
        private int secs = 0;
        private int mins = 0;
        private bool ReduceTime()
        {
            if (secs > 0)
            {
                --secs;
            }
            else if (secs == 0 && mins > 0)
            {
                --mins;
                secs = 59;
            }
            pause.IsEnabled = !(mins == secs && secs == 0);
            if (pause.IsEnabled == false) allowTimer = false;
            return mins != 0 || secs != 0;
        }

        private void secondsEntry_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Seconds_Enforcer(object sender, TextChangedEventArgs e)
        {
            Entry entry = sender as Entry;
            if (entry.Text is null) return;
            entry.Text = entry.Text.Replace(".", String.Empty);
            entry.Text = entry.Text.Replace("-", String.Empty);
            List<String> unwanteds = new List<String> { 6.ToString(), 7.ToString(), 8.ToString(), 9.ToString() };
            if (entry.Text.Length == 2 && unwanteds.IndexOf(entry.Text[0].ToString()) != -1)
            {
                //entry.Text = entry.Text.Substring(0,1);
                entry.Text = entry.Text.Substring(1, 1);
            }
        }
    }
}




    