using CorsoWpf.AsteroidRusset.DomainModel;
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

namespace CorsoWpf.AsteroidRusset.WpfApp
{
    /// <summary>
    /// Interaction logic for ComplexWindow.xaml
    /// </summary>
    public partial class ComplexWindow : Window
    {
        private static Random rnd = new Random((int)DateTime.Now.Ticks);

        public ComplexWindow()
        {
            // It's null :-S
            // this.lstNumbers.Items.Add(1);
            InitializeComponent();
            this.populateListFast();
        }

        private void populateListFast()
        {
            List<Sample> list = new List<Sample>();
            for (int i = 0; i < 1000000; i++)
            {
                var s = new Sample();
                list.Add(s);
            }

            this.lstNumbers.ItemsSource = list;
        }

        private void populateListSlow()
        {
            for (int i = 0; i < 10000000; i++)
            {
                int x = rnd.Next(1, 60000000);
                this.lstNumbers.Items.Add(x);
            }
        }
    }
}