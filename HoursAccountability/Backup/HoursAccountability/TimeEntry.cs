using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAccountability
{
    public struct TimeEntryKey
    {
        public DateTime Day;
        public string Type;
        public string Project;
        public string Activity;
    }

    public class TimeEntry
    {
        TimeSpan _duration;
        public TimeEntryKey Key;

        public TimeEntry()
        {
        }

        public TimeEntry(TimeEntryKey key)
        {
            Key = key;
        }

        public TimeSpan Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public DateTime? _startTimeStamp = null;

        #region "Timing"
        public delegate void SecondElapsedEventHandler(TimeEntry sender, TimeSpan elapsed);
        public event SecondElapsedEventHandler SecondElapsedEvent;
        protected virtual void RaiseSecondElapsedEvent()
        {
            if (_startTimeStamp.HasValue)
            {
                SecondElapsedEvent(this, DateTime.Now.Subtract(_startTimeStamp.Value));
            }
            else
            {
                SecondElapsedEvent(this, new TimeSpan(0));
            }
        }

        private System.Threading.TimerCallback _timerCallback = null;
        private System.Threading.Timer _timer = null;
        public void Start()
        {
            _startTimeStamp = DateTime.Now.Subtract(_duration);
            _timerCallback = new System.Threading.TimerCallback(TimerElapsed);
            _timer = new System.Threading.Timer(_timerCallback);
            _timer.Change(0, 1000);
        }

        public bool Running
        {
            get
            {
                return _startTimeStamp.HasValue;
            }
        }

        public void Stop()
        {
            if (_startTimeStamp != null)
            {
                _duration = DateTime.Now.Subtract(_startTimeStamp.Value);
                _timer.Change(System.Threading.Timeout.Infinite, 1000);
                _startTimeStamp = null;
            }
        }

        private void TimerElapsed(object stateInfo)
        {
            RaiseSecondElapsedEvent();
        }
        #endregion
    }

    public class SecondElapsedEventArgs : EventArgs
    {
        public readonly TimeSpan Elapsed;

        public SecondElapsedEventArgs(TimeSpan elapsed)
        {
            Elapsed = elapsed;
        }
    }
}
