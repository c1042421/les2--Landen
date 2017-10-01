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

namespace oefLanden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Land> landen;

        public MainWindow()
        {
            InitializeComponent();
            landen = new List<Land>();
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            string code = txtCode.Text;
            string hoofdstad = txtHoofdstad.Text;
            string staadshoofd = txtStaatshoofd.Text;

            Land land = getLandFromSelectedType(code, hoofdstad, staadshoofd);

            if (!landen.Contains(land) && land != null)
            {
                landen.Add(land);
                updateOutput();
                clearInputAndFocus();
            }
        }

        private void clearInputAndFocus()
        {
            txtCode.Clear();
            txtHoofdstad.Clear();
            txtStaatshoofd.Clear();

            rdbMonarchie.IsChecked = false;
            rdbOverig.IsChecked = false;
            rdbRepubliek.IsChecked = false;

            txtCode.Focus();
        }

        private void updateOutput()
        {
            txtOutput.Clear();
            foreach (Land land in landen)
            {
                txtOutput.Text += land.ToString() + Environment.NewLine;
            }
        }

        private Land getLandFromSelectedType(string code, string hoofdstad, string staadshoofd)
        {
            bool monarchie = rdbMonarchie.IsChecked ?? false;
            bool republiek = rdbRepubliek.IsChecked ?? false;
            bool overig = rdbOverig.IsChecked ?? false;

            if (monarchie)
            {
                return new Monarchie(code, hoofdstad, staadshoofd);
            }
            else if (republiek)
            {
                return new Republiek(code, hoofdstad, staadshoofd);
            }
            else if (overig)
            {
                return new Land(code, hoofdstad);
            }

            return null;
        }
    }
}
