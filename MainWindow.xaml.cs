using System;
using System.Collections.Generic;
using System.IO;
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

namespace Feladatok_nyilvántartása
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

        List<CheckBox> fsz = new List<CheckBox>();
        List<CheckBox> tl = new List<CheckBox>();

        private void Fajlok(object sender, RoutedEventArgs e)
        {
            if (File.Exists("fellista.dat"))
            {
                Ujhzzad(this.fsz, "fellista.dat");
            }

            else
            {
                File.Create("fellista.dat");
            }

            if (File.Exists("tfellista.dat"))
            {
                Ujhzzad(this.tl, "tfellista.dat");
            }

            else
            {
                File.Create("tfellista.dat");
            }
        }
*/
        private void Ujhzzad(object sender, RoutedEventArgs e)
        {
            string fsza = fsz.Text;

            if (fsza.Length > 0)
            {
                fl.Items.Add(new CheckBox { Content = $"{fsza}"});
                fsz.Clear();
            }

            if (fl.SelectedItems.Count == 1)
            {
                fsz.AppendText(fl.SelectedItems);
            }

            if (fl.Items.Count < 1)
            {
                fl.Items.Add(File.ReadAllLines("fellista.dat"));
            }

            else
            {
                File.Create("fellista.dat");
            }
        }

        private void Felmod(object sender, RoutedEventArgs e)
        {

        }

        private void Feltörl(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
