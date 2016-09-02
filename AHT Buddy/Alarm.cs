﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AHT_Buddy
{
    public class Alarm : System.Collections.ObjectModel.ObservableCollection<AlarmInfo>
    {
        public Alarm() : base() { }
    }
    public class AlarmInfo : INotifyPropertyChanged
    {
        private string name;
        private string time;
        private bool armed;
        public string onoff;


        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        public bool Armed
        {
            get { return armed; }
            set
            {
                armed = value;
                if(Armed == true)
                {
                    OnOff = "On";
                }
                else
                {
                    OnOff = "Off";
                }
                OnPropertyChanged("Armed");
            }
        }
        public string OnOff
        {
            get
            {
                return onoff;
          
            }
            set
            {
                onoff = value;
                OnPropertyChanged("OnOff");
            }
            
        }
    


        public AlarmInfo(string Name, string Time, string OnOff)
        {
            name = Name;
            time = Time;
            onoff = OnOff;

        }
        protected void OnPropertyChanged(string changeName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(changeName));
            }
        }




    }   
}
