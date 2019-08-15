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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductDataGridView.CurrentCell != null)
            {
                var rowIndex = ProductDataGridView.CurrentCell.RowIndex;

                var currentRow = ProductDataGridView.Rows[rowIndex];

                var cost = ProductDataGridView.CurrentRow.Cells[1].Value.ToString();
                var manufacturer = ProductDataGridView.CurrentRow.Cells[2].Value.ToString();
                var model = ProductDataGridView.CurrentRow.Cells[3].Value.ToString();

                string outputString = manufacturer + "  " + model + $"  {cost:C2}";

                SelectionTextBox.Text = outputString;
            }
        }
    }
}
