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

/*Assignment 5: Dollar Computers
 * Author: Mushfika Farzana
 * ID#: 301051702
 * Version: 2.4 - adding Order Form functionalities for Dollar Computers
 * Modified on: August 16, 2019
 */

namespace COMP123_S2019_Assignment5.Views
{
    public partial class OrderForm : Form
    {
        // Declaring constant for salex tax
        const decimal SALES_TAX = 0.13m;

        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is the event handler for the PrintToolStripMenuItem's Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
            MessageBox.Show("Printing Order...", "Print",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// this is the shared event handler for the ExitToolStripMenuItem Click event and CancelButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        /// <summary>
        /// this is the event handler for the AboutToolStripMenuItem's Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        /// <summary>
        /// this is the event handler for the OrderForm Activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ConditionDataLabel.Text = Program.product.condition;
            PriceDataLabel.Text = ((decimal)Program.product.cost).ToString("C");
            //PriceDataLabel.Text = ($"{Program.product.cost:C2}");
            PlatformDataLabel.Text = Program.product.platform;
            OSDataLabel.Text = Program.product.OS;
            ManufacturerDataLabel.Text = Program.product.manufacturer;
            ModelDataLabel.Text = Program.product.model;
            MemoryDataLabel.Text = Program.product.RAM_size;
            LCDSizeDataLabel.Text = Program.product.screensize;
            HDDDataLabel.Text = Program.product.HDD_size;
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUNumberDataLabel.Text = Program.product.CPU_number;
            GPUTypeDataLabel.Text = Program.product.GPU_Type;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            CPUSpeedDataLabel.Text = Program.product.CPU_speed;
            WebcamDataLabel.Text = Program.product.webcam;

            // Calculating Sales Tax
            SalesTaxDataLabel.Text = ((decimal)(Program.product.cost * SALES_TAX)).ToString("C");

            // Calculating Total Price
            TotalDataLabel.Text = ((decimal)(Program.product.cost * (1 + SALES_TAX))).ToString("C");

            // Setting image for the Computer Picture Box
            if (Program.product.platform == "Laptop")
            {
                ComputerPictureBox.Image = Properties.Resources.laptop;
            }
            else
            {
                ComputerPictureBox.Image = Properties.Resources.Desktop;
            }
        }

        /// <summary>
        /// This is the shared event handler for the BackButton and BackToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the shared event handler for the CancelButton and ExitToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thank You for shopping with Dollar Computers." + "\n" + 
                                    "Your order will be processed in 7-10 business days.", "Confirmation", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
