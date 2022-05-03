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

        }

    }
}
