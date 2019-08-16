using COMP123_S2019_Assignment5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Assignment 5: Dollar Computers
 * Author: Mushfika Farzana
 * ID#: 301051702
 * Version: 1.4 - Added Select Form functionalities for Dollar Computers
 * Modified on: August 14, 2019
 */

namespace COMP123_S2019_Assignment5.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the SelectForm's Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            //// TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

            if (!HasLoadedDataSource())
            {
                MessageBox.Show("DataSource Not Loaded", "ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool HasLoadedDataSource()
        {
            // throw new NotImplementedException();
            //return false;
            using (var db = new DollarCOmputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
                if (productBindingSource.DataSource != null)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// This is the event handler for the CancelButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the event handler for the NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();

            NextButton.Enabled = false;
        }

        /// <summary>
        /// /// <summary>
        /// This is the event handler for the ProductsDataGridView's SelectionChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductDataGridView.CurrentCell != null)
            {
                var rowIndex = ProductDataGridView.CurrentCell.RowIndex;

                var currentRow = ProductDataGridView.Rows[rowIndex];

                var cost = ((decimal)ProductDataGridView.CurrentRow.Cells[1].Value).ToString("C");
                var manufacturer = ProductDataGridView.CurrentRow.Cells[2].Value.ToString();
                var model = ProductDataGridView.CurrentRow.Cells[3].Value.ToString();

                string outputString = manufacturer + "  " + model + $"  Price: {cost}";

                SelectionTextBox.Text = outputString;
            }

            // this will enable the next button when a row is selected
            NextButton.Enabled = true; 

            // generating object from a line selected in ProductDataGridView
            Program.product.productID = short.Parse(ProductDataGridView.CurrentRow.Cells[0].Value.ToString());
            Program.product.cost = decimal.Parse(ProductDataGridView.CurrentRow.Cells[1].Value.ToString());
            Program.product.manufacturer = ProductDataGridView.CurrentRow.Cells[2].Value.ToString();
            Program.product.model = ProductDataGridView.CurrentRow.Cells[3].Value.ToString();
            Program.product.RAM_type = ProductDataGridView.CurrentRow.Cells[4].Value.ToString();
            Program.product.RAM_size = ProductDataGridView.CurrentRow.Cells[5].Value.ToString();
            Program.product.displaytype = ProductDataGridView.CurrentRow.Cells[6].Value.ToString();
            Program.product.screensize = ProductDataGridView.CurrentRow.Cells[7].Value.ToString();
            Program.product.resolution = ProductDataGridView.CurrentRow.Cells[8].Value.ToString();
            Program.product.CPU_Class = ProductDataGridView.CurrentRow.Cells[9].Value.ToString();
            Program.product.CPU_brand = ProductDataGridView.CurrentRow.Cells[10].Value.ToString();
            Program.product.CPU_type = ProductDataGridView.CurrentRow.Cells[11].Value.ToString();
            Program.product.CPU_speed = ProductDataGridView.CurrentRow.Cells[12].Value.ToString();
            Program.product.CPU_number = ProductDataGridView.CurrentRow.Cells[13].Value.ToString();
            Program.product.condition = ProductDataGridView.CurrentRow.Cells[14].Value.ToString();
            Program.product.OS = ProductDataGridView.CurrentRow.Cells[15].Value.ToString();
            Program.product.platform = ProductDataGridView.CurrentRow.Cells[16].Value.ToString();
            Program.product.HDD_size = ProductDataGridView.CurrentRow.Cells[17].Value.ToString();
            Program.product.HDD_speed = ProductDataGridView.CurrentRow.Cells[18].Value.ToString();
            Program.product.GPU_Type = ProductDataGridView.CurrentRow.Cells[19].Value.ToString();
            Program.product.optical_drive = ProductDataGridView.CurrentRow.Cells[20].Value.ToString();
            Program.product.Audio_type = ProductDataGridView.CurrentRow.Cells[21].Value.ToString();
            Program.product.LAN = ProductDataGridView.CurrentRow.Cells[22].Value.ToString();
            Program.product.WIFI = ProductDataGridView.CurrentRow.Cells[23].Value.ToString();
            Program.product.width = ProductDataGridView.CurrentRow.Cells[24].Value.ToString();
            Program.product.height = ProductDataGridView.CurrentRow.Cells[25].Value.ToString();
            Program.product.depth = ProductDataGridView.CurrentRow.Cells[26].Value.ToString();
            Program.product.weight = ProductDataGridView.CurrentRow.Cells[27].Value.ToString();
            Program.product.moust_type = ProductDataGridView.CurrentRow.Cells[28].Value.ToString();
            Program.product.power = ProductDataGridView.CurrentRow.Cells[29].Value.ToString();
            Program.product.webcam = ProductDataGridView.CurrentRow.Cells[30].Value.ToString();
        }
    }
}
