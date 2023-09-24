using DPnmea.Commands;
using DPnmea.Models;
using DPnmea.Views.N2kToNmea0183;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Windows.Data;

namespace DPnmea.ViewModels.N2kToNmea0183
{
    internal class TablePgnSentenceViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<LinePgnSentenceViewModel> PgnSentenceLineList { get; set; }

        public ListCollectionView PgnSentenceLineListView { get; set; }

        public TablePgnSentenceViewModel(string jsonInput)
        {
            PgnSentenceLineList = new ObservableCollection<LinePgnSentenceViewModel>();
            LoadJsonData(jsonInput);
            PgnSentenceLineListView = new ListCollectionView(PgnSentenceLineList);
        }

        private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsChecked")
            {
                // Mettre à jour CheckedCount ici
               
               ActifPGN = PgnSentenceLineList.Count(x => x.IsChecked);
            }
        }


        private int _totalPGN = 0;

        public int TotalPGN
        {
            get => _totalPGN;
            set
            {
                if (_totalPGN != value)
                {
                    _totalPGN = value;
                    OnPropertyChanged(nameof(TotalPGN));
                    OnPropertyChanged(nameof(TotalPGNText));
                }
            }
        }
        public string TotalPGNText
        {
            get { return $"Rx PGN Enable List ({_totalPGN} PGNs)"; }
        }

        private int _actifPGN = 0;

        public int ActifPGN
        {
            get => _actifPGN;
            set
            {
                if (_actifPGN != value)
                {
                    _actifPGN = value;
                    OnPropertyChanged(nameof(ActifPGN));
                    OnPropertyChanged(nameof(ActifPGNTexte));
                }
            }
        }

        public string ActifPGNTexte
        {
            get { return $"Enabled: {_actifPGN}/{_totalPGN}"; }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void LoadJsonData(string jsonInput)
        {
            var data = JsonConvert.DeserializeObject<TablePSDataStruct>(jsonInput);
            List<PgnSentenceDataStruct> PgnSentences = data.PSDataStruct;
            PgnSentenceLineList.Clear();
            ActifPGN = 0; // Réinitialiser le compteur
            TotalPGN = 0;

            foreach (PgnSentenceDataStruct item in PgnSentences)
            {
                var newItem = new LinePgnSentenceViewModel(JsonConvert.SerializeObject(item));
                newItem.PropertyChanged += Child_PropertyChanged;
                TotalPGN++;
                if (newItem.IsChecked)
                    ActifPGN++;
                PgnSentenceLineList.Add(newItem);
            }
            
        }


        /***********************************************  Gestion des cliques sur les bouttons *******************************************************/


        private ICommand _sortPgnCommand;

        public ICommand SortPgnCommand
        {
            get
            {
                if (_sortPgnCommand == null)
                {
                    _sortPgnCommand = new RelayCommand(param => this.SortPgnList(), param => true);
                }
                return _sortPgnCommand;
            }
        }

        private bool _isPgnSortedAscending = true; // Pour garder une trace de l'ordre de tri des PGN

        private void SortPgnList()
        {
            PgnSentenceLineListView.SortDescriptions.Clear(); // Effacer les anciennes descriptions de tri

            if (_isPgnSortedAscending)
            {
                PgnSentenceLineListView.SortDescriptions.Add(new SortDescription("PGNAsInt", ListSortDirection.Ascending));
            }
            else
            {
                PgnSentenceLineListView.SortDescriptions.Add(new SortDescription("PGNAsInt", ListSortDirection.Descending));
            }
            PgnSentenceLineListView.Refresh();
            _isPgnSortedAscending = !_isPgnSortedAscending; // Inverser l'ordre pour le prochain clic
        }



        private ICommand _sortCommand;

        public ICommand SortCommand
        {
            get
            {
                if (_sortCommand == null)
                {
                    _sortCommand = new RelayCommand(param => this.SortList(), param => true);
                }
                return _sortCommand;
            }
        }

        private bool _isSortedAscending = true; // Pour garder une trace de l'ordre de tri

        private void SortList()
        {
            PgnSentenceLineListView.SortDescriptions.Clear(); // Effacer les anciennes descriptions de tri

            if (_isSortedAscending)
            {
                PgnSentenceLineListView.SortDescriptions.Add(new SortDescription("IsChecked", ListSortDirection.Descending));
            }
            else
            {
                PgnSentenceLineListView.SortDescriptions.Add(new SortDescription("IsChecked", ListSortDirection.Ascending));
            }
            PgnSentenceLineListView.Refresh();
            _isSortedAscending = !_isSortedAscending; // Inverser l'ordre pour le prochain clic
        }




        private ICommand _applyDefaultsToHardwareCommand;

        public ICommand ApplyDefaultsToHardwareCommand
        {
            get
            {
                if (_applyDefaultsToHardwareCommand == null)
                {
                    _applyDefaultsToHardwareCommand = new RelayCommand(param => this.ApplyDefaultsToHardware(), param => this.CanApplyDefaults());
                }
                return _applyDefaultsToHardwareCommand;
            }
        }

        private void ApplyDefaultsToHardware()
        {
            MessageBoxResult result = MessageBox.Show("Êtes-vous sûr de vouloir réinitialiser aux valeurs par défaut ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {

            string defaultJsonPath = "Resources/defaultConfig.json"; // Ajustez le chemin selon votre structure de dossier
            string defaultConfig = File.ReadAllText(defaultJsonPath);
            LoadJsonData(defaultConfig);
            Console.WriteLine("Paramètres réinitialisés aux valeurs par défaut.");
            }
            else
            {
                Console.WriteLine("Réinitialisation annulée par l'utilisateur.");
            }
        }

        private bool CanApplyDefaults()
        {
            // Vérifier si les paramètres par défaut peuvent être appliqués
            return true; // ou false en fonction de la logique de ton application
        }



    }
}
