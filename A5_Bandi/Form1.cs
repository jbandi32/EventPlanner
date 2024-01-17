// Jared Bandi
// CPSC 275
// Homework 5 
// This program helps an event planner keep track of items and their
// cost, along with allowing the user to change the quantity of items


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5_Bandi
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

           
        }
        // Allows the user to select a specific file to open and read into listbox
        private BindingList<EventPlanner> receptionItems = new BindingList<EventPlanner>();
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (StreamReader fileInput = File.OpenText(openFileDialog.FileName))
                {

                    String input = fileInput.ReadLine();
                    while (input != null)
                    {
                        String[] inputArray = input.Split(',');

                        String item = inputArray[0];
                        double price = double.Parse(inputArray[1]);
                        int quantity = int.Parse(inputArray[2]);


                        receptionItems.Add(new EventPlanner(item, price, quantity));



                        input = fileInput.ReadLine();
                    }
                }
            }
            lbReceptionItems.DataSource = receptionItems;
            lbReceptionItems.DisplayMember = "DisplayString";
            btnOpenFile.Enabled = false;
        }
        // Saves File after the user changes it
        private void FileSave(object sender, EventArgs e)
        {
            
            StreamWriter saveFile = new StreamWriter(@"C:\Users\Owner\Downloads\Expenses.txt");
            saveFile.Write(lblNumOrderedNum.Text);
            saveFile.Close();

            


            }
            
        
        //closes file and saves changes the user made to file
        private void btnExit_Click(object sender, EventArgs e)
        {
           // FileSave(null, null);
            this.Close();
        }
        // Updates the labels at the bottom for cost per item, price of item, number ordered and total,
        // for the selected item.
        private void lbReceptionItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbReceptionItems.SelectedItem == null)
            {
                return;
            }

            EventPlanner selectedItem;

            selectedItem = receptionItems[lbReceptionItems.SelectedIndex];
            lblCPINum.Text = selectedItem.Price.ToString();
            lblNumOrderedNum.Text =selectedItem.Quantity.ToString();
            
            double CPI = double.Parse(lblCPINum.Text);
            double NumOrd = double.Parse(lblNumOrderedNum.Text);
            double tot = CPI * NumOrd;

            lblItemCostNum.Text = "$" + tot.ToString();

            double total = 0.0;
            for(int i =0; i < receptionItems.Count; i++)
            {
                total += (receptionItems[i].Price * receptionItems[i].Quantity);
            }
            lblTotalNum.Text = "$" + total.ToString();
        }

        private void lblCPINum_Click(object sender, EventArgs e)
        {
           
        }
        // Removes item from listbox when remove button is clicked
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            
                if (lbReceptionItems.SelectedValue != null)
                {
                    receptionItems.Remove((EventPlanner)lbReceptionItems.SelectedItem);
                lbReceptionItems_SelectedIndexChanged(null, null);
            }
                else
            {
                return;
            }
               
        }

    
        // Allows user to change the quantity of items when double clicking on item in listbox
        private void lbReceptionItems_DoubleClick(object sender, EventArgs e)
        {
            
            
            ItemQuantity itemQuantity = new ItemQuantity(this);
            EventPlanner selectedItem;
            //itemQuantity.ShowDialog();
            if (lbReceptionItems.SelectedValue != null)
            {
                selectedItem = receptionItems[lbReceptionItems.SelectedIndex];
                itemQuantity.Quantity = selectedItem.Quantity;

               itemQuantity.ShowDialog();

                selectedItem.Quantity = itemQuantity.Quantity;
                //itemQuantity.ShowDialog();

                lbReceptionItems_SelectedIndexChanged(null, null);
            }
            else
            {
                return;
            }
            
        }
        
    }

    }



