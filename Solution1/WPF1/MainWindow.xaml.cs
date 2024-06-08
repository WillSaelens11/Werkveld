using System.Data;
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

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataTable dt = new DataTable();

        public MainWindow()
        {
            InitializeComponent();

            dt.Columns.Add("Kolom 1", typeof(string));
            dt.Columns.Add("Kolom 2", typeof(string));
            dt.Columns.Add("Kolom 3", typeof(string));

            dataGrid.ItemsSource = dt.DefaultView;
        }

        private void VoegRijToe_Click(object sender, RoutedEventArgs e)
        {
            dt.Rows.Add("", "", "");
        }

        private void VerwijderRij_Click(object sender, RoutedEventArgs e)
        {
            int index = dataGrid.SelectedIndex;
            if (index >= 0 && index < dt.Rows.Count)
            {
                dt.Rows.RemoveAt(index);
            }
        }

        private void VoegKolomToe_Click(object sender, RoutedEventArgs e)
        {
            dt.Columns.Add("Nieuwe Kolom", typeof(string));
        }

        private void VerwijderKolom_Click(object sender, RoutedEventArgs e)
        {
            if (dt.Columns.Count > 0)
            {
                dt.Columns.RemoveAt(dt.Columns.Count - 1);
            }
        }
    }
}