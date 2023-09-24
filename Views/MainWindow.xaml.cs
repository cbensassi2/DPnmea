using DPnmea.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Threading;
using System.Globalization;
using System.Runtime.InteropServices;



namespace DPnmea.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //pour la console
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        //fin pour la console


        public MainWindow()
        {
            // Fixe la culture de l'UI pour utiliser la langue française
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
            AllocConsole();
            InitializeComponent();

            //this.DataContext = new MainWindowViewModel();

        }
    }
}
