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
using System.Windows.Shapes;
using TabelBL;
using TabelBL.Model;
using Werkveld.TabelBL.Model.DomeinModel;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
        }

        public void Click_Btn_BoolGlossary(object sender, RoutedEventArgs e)
        {
            BoolGlossary tabel = new BoolGlossary();
            _mainFrame.Navigate(new Tabel_Page(tabel.GetType())); // type meegeven aan page zodat hij weet hoe de tabel er uit mag zien
        }

        public void Click_Btn_ConstantGlossary(object sender, RoutedEventArgs e)
        {
            ConstantGlossary tabel = new ConstantGlossary();
            _mainFrame.Navigate(new Tabel_Page(tabel.GetType()));
        }

        public void Click_Btn_FunctionGlossary(object sender, RoutedEventArgs e)
        {
            FunctionGlossary tabel = new FunctionGlossary();
            _mainFrame.Navigate(new Tabel_Page(tabel.GetType()));
        }

        public void Click_Btn_RelationGlossary(object sender, RoutedEventArgs e)
        {
            RelationGlossary tabel = new RelationGlossary();
            _mainFrame.Navigate(new Tabel_Page(tabel.GetType()));
        }

        public void Click_Btn_TypeGlossary(object sender, RoutedEventArgs e)
        {
            TypeGlossary tabel = new TypeGlossary();
            _mainFrame.Navigate(new Tabel_Page(tabel.GetType()));
        }

    }
}
