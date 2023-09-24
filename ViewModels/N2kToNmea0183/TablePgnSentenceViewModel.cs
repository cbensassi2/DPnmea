using DPnmea.Commands;
using DPnmea.Models;
using DPnmea.Views.N2kToNmea0183;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DPnmea.ViewModels.N2kToNmea0183
{
    internal class TablePgnSentenceViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<LinePgnSentenceViewModel> PgnSentenceLineList { get; set; }

        public TablePgnSentenceViewModel(string jsonInput)
        {

            var data = JsonConvert.DeserializeObject<TablePSDataStruct>(jsonInput);
            List<PgnSentenceDataStruct> PgnSentences = data.PSDataStruct;

            PgnSentenceLineList = new ObservableCollection<LinePgnSentenceViewModel>();

            foreach (PgnSentenceDataStruct item in PgnSentences)
            {
                // Créer un nouveau ViewModel pour chaque élément et ajoute-le à la collection
                var newItem = new LinePgnSentenceViewModel(JsonConvert.SerializeObject(item));
                
                PgnSentenceLineList.Add(newItem);
            }

            TotalPGN = PgnSentenceLineList.Count;
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

        private int _actifPGN = 10;

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
            get { return $"Enabled:{_actifPGN}/{_totalPGN}"; }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /***********************************************  Gestion des cliques sur les bouttons *******************************************************/

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
            // Le code pour appliquer les paramètres par défaut au matériel
            Console.WriteLine("bouton apply default to hardware de l'onglet Nmea2000 ToString() nmea0183 as ExportedTypeExtensions ciliqué");
        }

        private bool CanApplyDefaults()
        {
            // Vérifier si les paramètres par défaut peuvent être appliqués
            return true; // ou false en fonction de la logique de ton application
        }



    }
}
