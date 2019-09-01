using System;
using System.Windows.Threading;

namespace Events
{
    internal class TimerWrapper
    {
        private DispatcherTimer _timer;

        public TimerWrapper(DispatcherTimer timer, EventHandler handler)
        {
            _timer = timer;
            ConfigureTimer(handler, 1);
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        private void ConfigureTimer(EventHandler handler, int interval)
        {
            _timer.Tick += handler;
            _timer.Interval = TimeSpan.FromSeconds(interval);
        }
    }
}
