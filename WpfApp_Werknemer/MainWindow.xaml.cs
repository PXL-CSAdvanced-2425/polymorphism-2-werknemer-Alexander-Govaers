using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Data;
using ClassLib.Data;
using ClassLib;


namespace WpfApp_Werknemer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Werknemer> werknemers;
        public List<Bediende> bediendes;

        public MainWindow()
        {
            InitializeComponent();

          

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
                if (openFileDialog.ShowDialog() == true)
                {
                    filename = openFileDialog.FileName;

                   werknemers = Data.ReadFile(filename);
                }
            
        }

        private void werknemerBtnClicked(object sender, RoutedEventArgs e)
        { listBoxWerknemers.Items.Clear();

            foreach (var item in werknemers)
            {
                listBoxWerknemers.Items.Add($"{item.FirstName + " " + item.LastName + " " + item.Salary()}");
            }
        }

        private void bediendeBtnClicked(object sender, RoutedEventArgs e)
        {
            listBoxWerknemers.Items.Clear();
            foreach (var item in werknemers)
            {
                if (item.Type == 'B')
                {
                    listBoxWerknemers.Items.Add(item.ToString());
                }
                
            }
        }

        private void kaderBtnClicked(object sender, RoutedEventArgs e)
        {
            listBoxWerknemers.Items.Clear();
            foreach (var item in werknemers)
            {
                if (item.Type == 'K')
                {
                    listBoxWerknemers.Items.Add(item.ToString());
                }

            }
        }

        private void commBtnClicked(object sender, RoutedEventArgs e)
        {
            listBoxWerknemers.Items.Clear();
            foreach (var item in werknemers)
            {
                if (item.Type == 'C')
                {
                    listBoxWerknemers.Items.Add(item.ToString());
                }

            }
        }
    }
}