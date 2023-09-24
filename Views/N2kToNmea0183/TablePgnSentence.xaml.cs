using DPnmea.ViewModels.N2kToNmea0183;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DPnmea.Views.N2kToNmea0183
{
    /// <summary>
    /// Logique d'interaction pour TablePgnSentence.xaml
    /// </summary>
    public partial class TablePgnSentence : UserControl
    {
        public TablePgnSentence()
        {
            InitializeComponent();

            var dataList = new 
            {
                PSDataStruct = new[]
                {
                    new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129036",
                        IsChecked = true,
                        Description = "Une autre description",
                        SentencesDataStruct = new[]
                        {
                             new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                           
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                           
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                          
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                         
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                           
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129036",
                        IsChecked = true,
                        Description = "Une autre description",
                        SentencesDataStruct = new[]
                        {
                             new { Id = 1, Text = "AAA", IsActivated = false },
                           
                            new { Id = 4, Text = "DDD", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                           
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                           
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129036",
                        IsChecked = true,
                        Description = "Une autre description",
                        SentencesDataStruct = new[]
                        {
                             new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129036",
                        IsChecked = true,
                        Description = "Une autre description",
                        SentencesDataStruct = new[]
                        {
                             new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129036",
                        IsChecked = true,
                        Description = "Une autre description",
                        SentencesDataStruct = new[]
                        {
                             new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129036",
                        IsChecked = true,
                        Description = "Une autre description",
                        SentencesDataStruct = new[]
                        {
                             new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129036",
                        IsChecked = true,
                        Description = "Une autre description",
                        SentencesDataStruct = new[]
                        {
                             new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129036",
                        IsChecked = true,
                        Description = "Une autre description",
                        SentencesDataStruct = new[]
                        {
                             new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129036",
                        IsChecked = true,
                        Description = "Une autre description",
                        SentencesDataStruct = new[]
                        {
                             new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = true,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129036",
                        IsChecked = true,
                        Description = "Une autre description",
                        SentencesDataStruct = new[]
                        {
                             new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    },new
                    {
                        PGNText = "129035",
                        IsChecked = false,
                        Description = "GNSS position rapid update",
                        SentencesDataStruct = new[]
                        {
                            new { Id = 1, Text = "AAA", IsActivated = false },
                            new { Id = 2, Text = "BBB", IsActivated = true },
                            new { Id = 3, Text = "CCC", IsActivated = true },
                            new { Id = 4, Text = "DDD", IsActivated = true },
                            new { Id = 5, Text = "EEE", IsActivated = true }
                        }
                    }
                }
                // Ajoute autant d'objets que tu veux ici
            };

            string jsonString = JsonConvert.SerializeObject(dataList, Formatting.Indented);

            this.DataContext = new TablePgnSentenceViewModel(jsonString);
        }
    }
}
