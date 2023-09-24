using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPnmea.Models
{
    internal class PgnSentenceDataStruct
    {
        public string PGNText { get; set; }
        public bool IsChecked { get; set; }
        public string Description { get; set; }
        public List<SentencesDataStruct> SentencesDataStruct { get; set; }
    }
}
