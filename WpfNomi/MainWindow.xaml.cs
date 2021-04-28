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

namespace WpfNomi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] nomi = new string[] { "Luca", "Marco", "Andrea", "Filippo" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            if(cboNomi.SelectedIndex == -1)
            {
                MessageBox.Show("NON HAI SELZIONATO NIENTE!", "ATTENZIONE");
            }
            else
            {
                string nome = cboNomi.SelectedItem.ToString();
                lboMostra.Items.Add($"Hai selezionato {nome}");
            }
        }

        private void btnRimuovi_Click(object sender, RoutedEventArgs e)
        {
            lboMostra.Items.Remove(lboMostra.SelectedItem);
        }

        private void btnPulisci_Click(object sender, RoutedEventArgs e)
        {
            lboMostra.Items.Clear();
        }

        private void cboNomi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for(int i = 0; i < nomi.Length; i++)
            {
                cboNomi.Items.Add(nomi[i]);
            }
        }
    }
}
