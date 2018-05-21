using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CorsoWpf.AsteroidRusset.WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            if (e.Args.Length == 0)
            {
                var window = new ComplexWindow();
                window.Show();
            }
            else
            {
                var file = e.Args[0];
                // fai qualcosa...
                Application.Current.Shutdown();
            }

            base.OnStartup(e);
        }
    }
}
