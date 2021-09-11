using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace MarthaScheduler2.Models
{
    public class Meetings : INotifyPropertyChanged
    {
        private string eventName;

        public string EventName
        {
            get { return this.eventName; }
            set 
            {
                this.eventName = value;
                this.RaisePropertyChanged("EventName");
            }
        }

        private string organizer;

        public string Organizer
        {
            get { return this.organizer; }
            set
            {
                this.organizer = value;
                this.RaisePropertyChanged("Organizer");
            }
        }

        private DateTime beginTime;

        public DateTime BeginTime
        {
            get { return this.beginTime; }
            set
            {
                this.beginTime = value;
                this.RaisePropertyChanged("BeginTime");
            }
        }

        private DateTime endTime;

        public DateTime EndTime
        {
            get { return this.endTime; }
            set
            {
                this.endTime = value;
                this.RaisePropertyChanged("EndTime");
            }
        }

        private Color  color;

        public Color Color
        {
            get { return this.color; }
            set
            {
                this.color = value;
                this.RaisePropertyChanged("Color");
            }
        }

        private bool  isAllDay;

        public bool IsAllDay
        {
            get { return this.isAllDay; }
            set
            {
                this.isAllDay = value;
                this.RaisePropertyChanged("IsAllDay");
            }
        }

        private string recurrenceRule;

        public string RecurrenceRule
        {
            get { return this.recurrenceRule; }
            set
            {
                this.recurrenceRule = value;
                this.RaisePropertyChanged("RecurrenceRule");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if(this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        

    }
}
