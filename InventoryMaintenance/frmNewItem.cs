using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        public frmNewItem()
        {
            InitializeComponent();
        }

        
        private void txtItemNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItemNo.Text == "")
            {
                MessageBox.Show("Please enter an Item Number");
            }

            if (txtDesc.Text == "")
            {
                MessageBox.Show("Please enter a Description");
            }

            if (!(Decimal.TryParse(txtPrice.Text, out decimal itemPrice))) ;
            {
                MessageBox.Show("Price must be numeric");
            }
        }

    }
}
