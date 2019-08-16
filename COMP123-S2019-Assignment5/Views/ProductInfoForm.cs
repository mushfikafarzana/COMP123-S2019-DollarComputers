using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Assignment 5: Dollar Computers
 * Author: Mushfika Farzana
 * ID#: 301051702
 * Version: 2.1 Adding Product Info Form functionalities for Dollar Computers
 * Modified on: August 15, 2019
 */

namespace COMP123_S2019_Assignment5.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the ProductInfoForm load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            // Disable Next button until the form is filled with data
            NextButton.Enabled = false;
        }

        /// <summary>
        /// This is the shared event handler for the SelectionButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the shared event handler for the CancelButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the shared event handler for the NextButton's click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            Program.selectForm.Hide();
        }

        /// <summary>
        /// this is the event handler for the ProductInfoForm Activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            GenerateProductInfo();
        }

        // Method that generates product information when a product is selected
        private void GenerateProductInfo()
        {
            if (Program.product.productID != 0)
            {
                ProductIDDataLabel.Text = Program.product.productID.ToString();
                ConditionDataLabel.Text = Program.product.condition;
                CostDataLabel.Text = ((decimal)Program.product.cost).ToString("C");
                //CostDataLabel.Text = ($"{Program.product.cost:C2}");
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

                //Enable Next button after the form is filled
                NextButton.Enabled = true;
            }
        }

        /// <summary>
        /// this is the event handler for the SaveToolStripMenuItem's Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            ProductInfoSaveFileDialog.FileName = "Product.txt";
            ProductInfoSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All files (*.*)|*.*";

            // open file dialog - Modal Form
            var result = ProductInfoSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // open a stream to write
                    using (StreamWriter outputString = new StreamWriter(
                       File.Open(ProductInfoSaveFileDialog.FileName, FileMode.Create)))
                    {
                        // write content - string type - to file
                        outputString.WriteLine(Program.product.productID.ToString());
                        outputString.WriteLine(Program.product.condition.ToString());
                        outputString.WriteLine(Program.product.cost.ToString());
                        outputString.WriteLine(Program.product.platform.ToString());
                        outputString.WriteLine(Program.product.OS.ToString());
                        outputString.WriteLine(Program.product.manufacturer.ToString());
                        outputString.WriteLine(Program.product.model.ToString());
                        outputString.WriteLine(Program.product.RAM_size);
                        outputString.WriteLine(Program.product.screensize);
                        outputString.WriteLine(Program.product.HDD_size);
                        outputString.WriteLine(Program.product.CPU_brand);
                        outputString.WriteLine(Program.product.CPU_number);
                        outputString.WriteLine(Program.product.GPU_Type);
                        outputString.WriteLine(Program.product.CPU_type);
                        outputString.WriteLine(Program.product.CPU_speed);
                        outputString.WriteLine(Program.product.webcam);

                        //cleanUp
                        outputString.Close();
                        outputString.Dispose();
                    }

                    // give feedback to user that file has been saved
                    // this is a modal form
                    MessageBox.Show("File Saved Successfully", "Saving...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException exception)
                {
                    MessageBox.Show("ERROR" + exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }
        /// <summary>
        /// this is the event handler for the OpenToolStripMenuItem's Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }

        // Method that opens a OpenFileDialog box
        public void OpenFileDialog()
        {
            // configure the file dialog
            ProductInfoOpenFileDialog.FileName = "Product.txt";
            ProductInfoOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = ProductInfoOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // Open stream to read
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(ProductInfoOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // Read stuff from the file into the Product class
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();

                        // cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);
                    MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message + "\nPlease select the appropriate file type", "File I/O Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            GenerateProductInfo();
        }
    }
}
