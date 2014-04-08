using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Fligern.UsefulReminder.Helpers;

namespace Fligern.UsefulReminder
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand CommandNext;
        public ICommand CommandClose;

        private string _label;
        public string Label
        {
            get
            {
                return _label;
            }
            set
            {
                _label = value;
                RaisePropertyChanged("Label");
            }
        }

        private string _quoteText;
        public string QuoteText
        {
            get
            {
                return _quoteText;
            }
            set
            {
                _quoteText = value;
                RaisePropertyChanged("QuoteText");
            }
        }               

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            CommandClose = new RelayCommand(Close);
            CommandNext = new RelayCommand(Next);
        }

        public void Close(object arg)
        {
        }
        public void Next(object arg)
        {
        }
        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
