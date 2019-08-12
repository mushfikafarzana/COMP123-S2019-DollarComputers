using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for shopping with Dollar Computers.\n Your order will be processed in 7-10 business days.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
