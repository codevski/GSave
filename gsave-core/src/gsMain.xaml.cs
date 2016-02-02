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

namespace gsaveapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class gsMain : Window
    {
        public gsMain()
        {
            InitializeComponent();
            Hide();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = e.OriginalSource as MenuItem;
            switch (item.Name)
            {
                case "Close":
                    this.Close();
                    break;
            }
        }

        private void backupGame(object sender, RoutedEventArgs e)
        {
            if(gamebox.IsChecked.HasValue && gamebox.IsChecked.Value)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = @"/C ROBOCOPY C:\Users\sashp\Desktop\Old C:\Users\sashp\Desktop\New";

                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show("Copied file to desktop");
            }
            else
            {
                MessageBox.Show("Unticked FALSE");
            }
        }

        private void restore()
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

    }
}
