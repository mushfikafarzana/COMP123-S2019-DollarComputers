using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Assignment 5: Dollar Computers
 * Author: Mushfika Farzana
 * ID#: 301051702
 * Version: 1.2 Finalized Splash Screen, Start Form and About Form functionalities for Dollar Computers
 * Modified on: August 10, 2019
 */

namespace COMP123_S2019_Assignment5.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = true;
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;
            Program.startForm.Show();
            this.Hide();
        }
    }
}
