using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;  // Tu auras besoin de Newtonsoft.Json pour ça
using System.Collections.ObjectModel;
using System.ComponentModel;
using static DPnmea.ViewModels.N2kToNmea0183.SentenceViewModel;
using DPnmea.Models;

namespace DPnmea.ViewModels.N2kToNmea0183
{
    internal class ListSentencesViewModel : INotifyPropertyChanged
    {

        private bool _isEnabled = true;

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    foreach (SentenceViewModel item in CheckBoxList)
                    {
                        item.IsEnabled = _isEnabled;
                    }
                    OnPropertyChanged(nameof(IsEnabled));
                }
            }
        }

        public ObservableCollection<SentenceViewModel> CheckBoxList { get; set; }

        public ListSentencesViewModel(List<SentencesDataStruct> sentences)
        {

            CheckBoxList = new ObservableCollection<SentenceViewModel>();


            foreach (SentencesDataStruct item in sentences)
            {
                // Créer un nouveau ViewModel pour chaque élément et ajoute-le à la collection
                var newItem = new SentenceViewModel(item.Id, item.Text, item.IsActivated);

                // Abonnement à l'événement
                newItem.IsCheckedChanged += OnChildIsCheckedChanged;

                CheckBoxList.Add(newItem);
            }
        }

        // INotifyPropertyChanged et autres choses habituelles ici

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private class CheckBoxItem
        {
            public int Id { get; set; }
            public string Text { get; set; }
            public bool IsActivated { get; set; }
        }


        private void OnChildIsCheckedChanged(object sender, CheckBoxChangedEventArgs e)
        {
            Console.WriteLine($"Id: {e.Id}, Text: {e.Text}, IsChecked: {e.IsChecked}");
        }


    }
}
