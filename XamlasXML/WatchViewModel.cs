using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Timers;
using Xamarin.Forms;


namespace XamlasXML
{
    public class WatchViewModel : INotifyPropertyChanged
    {
        Stopwatch stopWatch = new Stopwatch();
        private Timer time = new Timer();
          private string _stopWatchMinutes;
        //public Command<object> StartButton { get; set; }
        //public string Entry1 { get; set; }
        //public string Entry2 { get; set; }


        public string StopWatchMinutes
        {
            get { return _stopWatchMinutes; }
            set
            {
                _stopWatchMinutes = value;
                OnPropertyChanged("StopWatchMinutes");
            }
        }
        private string _stopWatchSeconds;
        public string StopWatchSeconds
        {
            get { return _stopWatchSeconds; }
            set
            {
                _stopWatchSeconds = value;
                OnPropertyChanged("StopWatchSeconds");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyname)
        {
            var changed = PropertyChanged;
            if(changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public WatchViewModel()
        {
            //StartButton = new Command<object>(OnTapped);
            stopWatch.Start();
            StopWatchMinutes = stopWatch.Elapsed.Minutes.ToString();
            StopWatchSeconds = stopWatch.Elapsed.Seconds.ToString();

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                StopWatchMinutes = stopWatch.Elapsed.Minutes.ToString();
                StopWatchSeconds = stopWatch.Elapsed.Seconds.ToString();
                return true;
            });

        }
        //private void OnTapped(Object obj)
        //{

        //}
        //private void Start_Watch(object sender, EventArgs e)
        //{
        //  var counter = 0;
        //   Entry entry = sender as Entry;
        //   var firstEntry = Double.Parse(entry1.Text);
        ////   Device.StartTimer(TimeSpan.FromSeconds(firstEntry), () => {
        ////       counter--;
        ////       return true;
        ////   });

    }
}
