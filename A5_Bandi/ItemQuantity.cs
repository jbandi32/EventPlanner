using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5_Bandi
{
    public partial class ItemQuantity : Form
    {
        private Form1 mainForm;
        
        public ItemQuantity(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
        private void ItemQuantity_Load(object sender, EventArgs e)
        {

        }
        //Closes second form and sets the quanity to null so it returns back to original value 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtQuantityNum.Text = null;
            this.Close();
        }
        //Closes form
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Get and set methods for Quantity value
        public int Quantity
        {
            get
            {
               return  (int.Parse(txtQuantityNum.Text)) ;
            }
            set
            {
                txtQuantityNum.Text = Text;
            }

        }
            
    }
}
