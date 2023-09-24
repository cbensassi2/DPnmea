using DPnmea.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPnmea.ViewModels.N2kToNmea0183
{
    internal class LinePgnSentenceViewModel : INotifyPropertyChanged
    {

        public int PGNAsInt => int.TryParse(PGNText, out int result) ? result : 0;

        private bool _isChecked;
        private string _pgnText;
        private string _description;
        private ListSentencesViewModel _listSentences;

        private bool _isEnabled = true;

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    ListSentences.IsEnabled = _isEnabled;
                    OnPropertyChanged(nameof(IsEnabled));
                }
            }
        }

        public ListSentencesViewModel ListSentences
        {
            get => _listSentences;
            set
            {
                if (_listSentences != value)
                {
                    _listSentences = value;
                    OnPropertyChanged(nameof(ListSentences));
                }
            }
        }

        public LinePgnSentenceViewModel(string jsonInput)
        {
            var data = JsonConvert.DeserializeObject<PgnSentenceDataStruct>(jsonInput);
            List<SentencesDataStruct> Sentences = data.SentencesDataStruct;
            ListSentences = new ListSentencesViewModel(Sentences);

            PGNText = data.PGNText;
            IsChecked = data.IsChecked;
            IsEnabled = data.IsChecked;
            ListSentences.IsEnabled = data.IsChecked;
            Description = data.Description;


        }

        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                if (_isChecked != value)
                {
                    _isChecked = value;
                    IsEnabled = _isChecked;
                    OnPropertyChanged(nameof(IsChecked));
                }
            }
        }

        public string PGNText
        {
            get => _pgnText;
            set
            {
                if (_pgnText != value)
                {
                    _pgnText = value;
                    OnPropertyChanged(nameof(PGNText));
                }
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
