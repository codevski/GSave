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

namespace gsaveapp
{
    /// <summary>
    /// Interaction logic for gsSplash.xaml
    /// </summary>
    public partial class gsSplash : Window
    {
        public event EventHandler Shown;

        public gsSplash()
        {
            InitializeComponent();
            Shown += new EventHandler(Check_Updates);
            // Load Main hidden
            //formMain_Load();
            //Close();
            MessageBox.Show("test");
            this.Close();
        }

        /*private void formMain_Load()
        {
            gsMain main = new gsMain();
            main.Show();
        }*/

        public void Check_Updates(Object sender, EventArgs e)
        {
            // Check if latest version
            // Check database latest version
            // Any other checks
            MessageBox.Show("Have checked everything");
            txtStatus.Text = "Checking for update";
        }

    }
}
