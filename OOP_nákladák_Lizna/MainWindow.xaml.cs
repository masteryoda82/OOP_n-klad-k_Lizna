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

namespace OOP_nákladák_Lizna
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nakladak tatra;
        Nakladak man;
        

        public MainWindow()
        {
            InitializeComponent();
            tatra = new Nakladak();
            tatra.Nazev = "Tatra";
            Zobraz(tatra, txtb1);

            man = new Nakladak();
            man.Nazev = "Man";
            Zobraz(man, txtb2);
        }
        public void Zobraz (Nakladak nakladak, TextBlock textBlock)
        {
            textBlock.Text = nakladak.Nazev + "\n";
            textBlock.Text += "Nosnost = " + nakladak.Nosnost.ToString() + "kg" + "\n";
            textBlock.Text += "Naloženo =" + nakladak.Naklad.ToString() + "kg" + "\n";
            textBlock.Text += "Celková vzdálenost =" + nakladak.Celkova_vzdalenost.ToString() + "km" + "\n";
            textBlock.Text += "Palivo =" + nakladak.Palivo.ToString() + "l" + "\n";
            textBlock.Text += "Objem nádrže =" + nakladak.Objem_nadrzre + "l" + "\n";
            textBlock.Text += "Spotřeba paliva =" + nakladak.Spotreba_nadrze + "l" + "\n";
        }

        private void nalozit_Click(object sender, RoutedEventArgs e)
        {
            tatra.nalozit();
            man.nalozit();
            Zobraz(tatra, txtb1);
            Zobraz(man, txtb2);
        }

        private void vylozit_Click(object sender, RoutedEventArgs e)
        {
            tatra.vylozit();
            man.vylozit();
            Zobraz(tatra, txtb1);
            Zobraz(man, txtb2);
        }

        private void natankovat_Click(object sender, RoutedEventArgs e)
        {
            tatra.natankovat();
            man.natankovat();
            Zobraz(tatra, txtb1);
            Zobraz(man, txtb2);
        }

        private void jet_Click(object sender, RoutedEventArgs e)
        {
            tatra.jet();
            man.jet();
            Zobraz(tatra, txtb1);
            Zobraz(man, txtb2);
        }
    }
}
