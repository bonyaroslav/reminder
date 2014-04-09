using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Fligern.UsefulReminder.Base;
using Fligern.UsefulReminder.Helpers;

namespace Fligern.UsefulReminder
{
    public class MainViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The command next
        /// </summary>
        public ICommand CommandNext;
        /// <summary>
        /// The command close
        /// </summary>
        public ICommand CommandClose;
        /// <summary>
        /// The on close
        /// </summary>
        public EventHandler OnClose;

        private DataManager _dataManager;
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
            _dataManager = new DataManager();
            _dataManager.Load();
        }

        public void Close(object arg)
        {
            if (OnClose != null)
            {
                OnClose(null,null);
            }
        }

        public void Next(object arg)
        {
            FetchRandomData();
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void FetchRandomData()
        {
            var result = _dataManager.GetDataRandom();
            if (result.Number >= 0)
            {
                Label = string.Format("{0}/{1}", result.Number + 1, _dataManager.Amount);
                QuoteText = result.Data;

            }
        }
    }
}
