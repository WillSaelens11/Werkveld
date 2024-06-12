using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TabelBL;
using TabelBL.Model;
using TabelBL.Model.DomeinModel;
using Werkveld.TabelBL.Model.DomeinModel;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for BoolGlossary_Page.xaml
    /// </summary>
    public partial class Tabel_Page : Page
    {
        private DataTable dt = new DataTable();


        private static Dictionary<string, int> instanceCounts = new Dictionary<string, int>();


        public Tabel_Page(Type type)
        {
            InitializeComponent();

            //if (type is BoolGlossary)
            //{
            //    BoolGlossary tabel = new BoolGlossary();
            //    for(int i = 0; i < tabel.AantalKolommen; i++)
            //    {
            //        dt.Columns.Add("Kolom " + i, typeof(string));
            //    }
            //}

            string typeName = type.Name;
            if (!instanceCounts.ContainsKey(typeName))
            {
                instanceCounts[typeName] = 0;
            }
            instanceCounts[typeName]++;

            // Stel de titel van de pagina in op basis van het type tabel en het aantal instanties
            this.Title = "Tabel " + typeName + " " + instanceCounts[typeName];

            dt.Columns.Add("Kolom 1", typeof(string));
            dt.Columns.Add("Kolom 2", typeof(string));
            /*dt.Columns.Add("Kolom 3", typeof(string));*/

            dataGrid.ItemsSource = dt.DefaultView;
        }

        private void VoegRijToe_Click(object sender, RoutedEventArgs e)
        {
            dt.Rows.Add("", "");
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


        // 

        public void WijzigKolomNaam(int kolomIndex, string nieuweNaam)
        {
            if (kolomIndex >= 0 && kolomIndex < dataGrid.Columns.Count)
            {
                dataGrid.Columns[kolomIndex].Header = nieuweNaam;
            }

        }


        private void DataGridColumnHeader_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridColumnHeader column = sender as DataGridColumnHeader;
            if (column != null)
            {
                string nieuweNaam = Microsoft.VisualBasic.Interaction.InputBox("Voer de nieuwe kolomnaam in", "Wijzig kolomnaam", column.Content.ToString());
                if (!string.IsNullOrEmpty(nieuweNaam))
                {
                    column.Content = nieuweNaam;
                }
            }
        }

        private void SaveData_Click(object sender, RoutedEventArgs e)
        {
            // Implementeer hier je logica voor het opslaan van de data
        }
    }

}