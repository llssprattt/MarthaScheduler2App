using MarthaScheduler2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace MarthaScheduler2.ViewModels
{
    public class ViewModel
    {
        public ObservableCollection<Meetings>Meetings { get; set; }
        
        List<string> eventNameCollection;
        List<Color> colorCollection;

        public ViewModel()
        {
            this.Meetings = new ObservableCollection<Meetings>();
            this.CreateEventNameCollection();
            this.CreateColorCollection();
            this.CreateAppointments();
        }

        private void CreateAppointments()
        {
            Random randomTime = new Random();
            List<Point> randomTimeCollection = GetTimeRanges();
            DateTime date;
            DateTime DateFrom = DateTime.Now.AddDays(-10);
            DateTime DateTo = DateTime.Now.AddDays(10);
            DateTime dateRangeStart = DateTime.Now.AddDays(-3);
            DateTime dateRangeEnd = DateTime.Now.AddDays(3);

            for (date = DateFrom; date < DateTo; date = date.AddDays(1)) ;
        }

        private List<Point> GetTimeRanges()
        {
            List<Point> randomTimeCollection = new List<Point>();
            randomTimeCollection.Add(new Point(9, 11));
            randomTimeCollection.Add(new Point(12, 14));
            randomTimeCollection.Add(new Point(15, 17));
            return randomTimeCollection;
        }

        private void CreateColorCollection()
        {
            throw new NotImplementedException();
        }

        private void CreateEventNameCollection()
        {
            throw new NotImplementedException();
        }
    }
}
