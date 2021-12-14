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

            if (fsz.Text.Length >= 0)
            {
                CheckBox elem = new CheckBox();
                elem.Content = fsza;
                elem.AddHandler(CheckBox.CheckedEvent, new RoutedEventHandler(elem_isChecked));
                elem.AddHandler(CheckBox.UncheckedEvent, new RoutedEventHandler(elem_isUnchecked));
                fl.Items.Add(elem);
                fsz.Clear();
            }
            /*
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
            */
        }

        private void elem_isChecked(object sender, RoutedEventArgs e)
        {
            (sender as CheckBox).Foreground = new SolidColorBrush(Colors.Gray);
            (sender as CheckBox).FontStyle = FontStyles.Italic;
        }

        private void elem_isUnchecked(object sender, RoutedEventArgs e)
        {
            (sender as CheckBox).Foreground = new SolidColorBrush(Colors.Black);
            (sender as CheckBox).FontStyle = FontStyles.Normal;
        }

        protected void Kivalaszt(object sender, KeyboardFocusChangedEventArgs e)
        {
            ListViewItem fl = (ListViewItem)sender;
            fl.IsSelected = true;
        }

        private void Felmod(object sender, RoutedEventArgs e)
        {
            if (fl.SelectedItems.Count == 1)
            {

            }
        }

        private void Feltörl(object sender, RoutedEventArgs e)
        {
            if (fl.SelectedItems.Count == 1)
            {
                tl.Items.Add(new CheckBox { Content = $"{fl.SelectedItems}" });
                File.WriteAllText("tfellista.dat");
                fl.SelectedItems.Remove;
            }
        }
    }
}