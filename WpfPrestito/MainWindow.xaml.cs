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

namespace WpfPrestito
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public void Calcola_Click(object sender, RoutedEventArgs e)
        {
            double richiesta = double.Parse(txtImportoRichiesto.Text);
            double rate = double.Parse(txtNRate.Text);
            double percentuale = double.Parse(txtPercentuale.Text);
            double interesse = (richiesta / 100) * percentuale;
            double restituire = interesse + richiesta;
            double per_rata = restituire / rate;
            txtImportoDaRestituire.Text = ($"{restituire}");
            txtImportoPerRata.Text = ($"{per_rata}");
        }

        public void Stampa_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtNome.Text;
            string cognome = txtCognome.Text;
            string data = dataPicker;
            string luogo = ComboBoxItem;
            if (Femmina.IsChecked == true )
                lblStampato.Content = ($"{cognome} {nome} residente in {} nata il {}. Prestito di {txtImportoRichiesto}€ ad un tasso del {txtPercentuale}% da restituire in {txtNRate} da {txtImportoPerRata}€ ciascuna, per un totale di {txtImportoDaRestituire}€");
            else if (Maschio.IsChecked == true)
                lblStampato.Content = ($"{cognome} {nome} residente in {} nato il {}. Prestito di {txtImportoRichiesto}€ ad un tasso del {txtPercentuale}% da restituire in {txtNRate} da {txtImportoPerRata}€ ciascuna, per un totale di {txtImportoDaRestituire}€");
        }
    }
}
