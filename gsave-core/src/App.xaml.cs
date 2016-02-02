using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;

namespace gsaveapp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    public partial class App : Application
    {
        public event EventHandler Shown;

        private void App_Start(object sender, StartupEventArgs e)
        {
            // Load Splash in seperate thread
            //splash_Load();
            gsSplash splash = new gsSplash();
            splash.Show();


            // Check for updates before loading main application
            var update_thread = Task.Run(() => { Check_Updates(); });
            update_thread.Wait();

            // Load Main hidden
            formMain_Load();

            // close splash when main is done
            splash.Close();

        }
        private void splash_Load()
        {
            gsSplash splash = new gsSplash();
            splash.Show();
        }
        private void formMain_Load()
        {
            gsMain main = new gsMain();
            main.Show();

        }

        private void Check_Updates()
        {
            // Check if latest version
            // Check database latest version
            // Any other checks
            MessageBox.Show("Have checked everything");
        }
    }
}
