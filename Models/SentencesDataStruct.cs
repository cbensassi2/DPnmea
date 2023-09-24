using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPnmea.Models
{
    internal class SentencesDataStruct
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsActivated { get; set; }
    }
}
