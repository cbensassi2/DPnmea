using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DPnmea.Commands;
using System.Windows.Media;

namespace DPnmea.ViewModels.N2kToNmea0183
{
    internal class SentenceViewModel : INotifyPropertyChanged
    {

        public class CheckBoxChangedEventArgs : EventArgs
        {
            public int Id { get; }
            public string Text { get; }
            public bool IsChecked { get; }

            public CheckBoxChangedEventArgs(int id, string text, bool isChecked)
            {
                Id = id;
                Text = text;
                IsChecked = isChecked;
            }
        }


        public SentenceViewModel()
        {
            
        }

        // J'ai ajouté un ID ici
        public int Id { get; set; }

        // J'ai ajusté le constructeur pour prendre des paramètres
        public SentenceViewModel(int id, string text, bool isChecked)
        {
            Id = id;
            Text = text;
            IsChecked = isChecked;
        }


        public Brush TextColor
        {
            get
            {
                return IsChecked ? Brushes.Black : Brushes.Gray;
            }
        }

        private bool _isChecked;
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                if (_isChecked != value) // Ajouté pour éviter des appels inutiles
                {
                    _isChecked = value;
                    OnPropertyChanged(nameof(IsChecked));
                    OnPropertyChanged(nameof(TextColor));  // Ceci informe que TextColor a changé

                    IsCheckedChanged?.Invoke(this, new CheckBoxChangedEventArgs(Id, Text, IsChecked));
                }
            }
        }

        private bool _isEnabled = true;

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    OnPropertyChanged(nameof(IsEnabled));
                }
            }
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        public event EventHandler<CheckBoxChangedEventArgs>? IsCheckedChanged;

        

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}
