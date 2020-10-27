
using System;
using System.Windows.Markup;

namespace Seconds_Convertor
{
    class Data
    {
        private double all_seconds;
        private double seconds;
        private double minutes;
        private double hours;
        private double days;
        private double years;
        private double century;
        public Data() : this(0) { }
        public Data(double all_seconds)
        {
            this.all_seconds = all_seconds;
            seconds = 0;
            minutes = 0;
            hours = 0;
            days = 0;
            years = 0;
            century = 0;
        }
        public void Clear_Data()
        {
            all_seconds = 0;
            seconds = 0;
            minutes = 0;
            hours = 0;
            days = 0;
            years = 0;
            century = 0;
        }
        public double All_Seconds
        {
            get { return all_seconds; }
            set
            {
                if (value >= 0)
                    all_seconds = value;
                else
                    all_seconds = 0;
            }
        }
        public double Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0)
                    seconds = value;
                else
                    seconds = 0;
            }
        }
        public double Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0)
                    minutes = value;
                else
                    minutes = 0;
            }
        }
        public double Hours
        {
            get { return hours; }
            set
            {
                if (value >= 0)
                    hours = value;
                else
                    hours = 0;
            }
        }
        public double Days
        {
            get { return days; }
            set
            {
                if (value >= 0)
                    hours = value;
                else
                    hours = 0;
            }
        }
        public double Years
        {
            get { return years; }
            set
            {
                if (value >= 0)
                    years = value;
                else
                    years = 0;
            }
        }
        public double Century
        {
            get { return century; }
            set
            {
                if (value >= 0)
                    years = value;
                else
                    years = 0;
            }
        }
        public Data Convert()
        {
            seconds = all_seconds;
            if (seconds >= 60)
            {
                minutes = seconds / 60;
                seconds = seconds % 60;
            }
            if (minutes >= 60)
            {
                hours = minutes / 60;
                minutes = minutes % 60;
            }
            if (hours >= 24)
            {
                days = hours / 24;
                hours = hours % 24;
            }
            if (days >= 365)
            {
                years = days / 365;
                days = days % 365;
            }
            if(years>=100)
            {
                century = years / 100;
                years = years % 100;
            }
            seconds = (int)seconds;
            minutes = (int)minutes;
            hours = (int)hours;
            days = (int)days;
            years = (int)years;
            century = (int)century;
            return this;
        }
        public override string ToString()
        {
            string str = "";
            if (century > 0)
                str += century.ToString() + " Century\n";
            if (years > 0)
                str += years.ToString() + " Years\n";
            if (hours > 0)
                str += hours.ToString() + " Hours\n";
            if (minutes > 0)
                str += minutes.ToString() + " Minutes\n";
            str += seconds.ToString() + " Seconds\n";
            return str;
        }
    }
}
