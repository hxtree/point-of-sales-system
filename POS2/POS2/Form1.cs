using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace POS2
{
    public partial class Form1 : Form
    {
        // Globals
        decimal salesTax = .06M;
        // array in class
        salesrecord salesRecord1 = new salesrecord();


        public Form1()
        {
            InitializeComponent();
            loadInventory();
        }

         private void showRecords(){
             // view record form
             string recordOut = "Here is a list of the sales records currently in the system:\n\n";
             if (salesRecord1.salesRecord.Count > 0)
             {

                 for (int record = 0; record < salesRecord1.salesRecord.Count; record++)
                 {
                     recordOut += salesRecord1.salesRecord[record] + "\n";
                 }
             }
             else
             {
                 recordOut = "There no sales records to view";
             }
             MessageBox.Show(recordOut, "View Sales Records");

         }

         private void lookup()
         {
             try
             {
                 // shows last record
                 string output = "Here is the last sales record:\n\n" + salesRecord1.salesRecord[salesRecord1.salesRecord.Count - 1];
                 MessageBox.Show(output, "Look-up");
             }
             catch {
                 MessageBox.Show("There are no records to look-up", "Look-up");
             }
         }
        private void Form1_Load(object sender, EventArgs e)
        {
            // set extended total
            lblExtendedTotal.Text = String.Format("Extended Total:   {0:C}", 0);
            // set order total
            lblOrderTotal.Text = String.Format("Order Total:   {0:C}", 0);
            // set tax
            lblTaxTotal.Text = String.Format("Tax ({0}%):   {1:C}", salesTax, 0);
            // set grand total
            lblGrandTotal.Text = String.Format("Grand Total:   {0:C}", 0);

        }
        private void updateRecords(){
            // updates records display on bottom of the page
            lsBoxSalesRecord.Items.Clear();
            for (int i = 0; i < salesRecord1.salesRecord.Count; i++)
            {
                lsBoxSalesRecord.Items.Add(salesRecord1.salesRecord[i]);
            }
        }
        private void refundOrder()
        {
            // removes last sales record
            try
            {
                salesRecord1.salesRecord.RemoveAt(salesRecord1.salesRecord.Count - 1);
                MessageBox.Show("The last order has succesfully been refund");
            }
            catch
            {
                MessageBox.Show("There are no orders to refund");
            }
            updateRecords();
       }
        private void loadInventory()
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(Application.StartupPath + @"\inventory.txt");

            while ((line = file.ReadLine()) != null)
            {
                inventory1.Items.Add(line);
                counter++;
            }

            file.Close();
        }
        private void printReceipt()
        {
            string receipt =
                "=========================" + "\n"
                + "PRICE CHOPPERS" + "\n"
                + "=========================" + "\n"
                + DateTime.Now + "\n"
                + "=========================" + "\n"
                + "\n";

            for (int i = 0; i < cBoxShoppingCart.Items.Count; i++)
            {
                receipt += cBoxShoppingCart.Items[i].ToString() + "\n";

            }

            receipt +=
                "\n"
                + lblOrderTotal.Text + "\n"
                + lblTaxTotal.Text + "\n"
                + lblGrandTotal.Text + "\n"
                + "=========================" + "\n"
                + "THANK YOU FOR SHOPPING!" + "\n"
                ;

            MessageBox.Show(receipt);
        }
        private void changeShoppingList(string adjustment)
        {
            switch (adjustment)
            {
                case "add":
                    foreach (string line in inventory1.CheckedItems)
                    {
                        cBoxShoppingCart.Items.Add(line);
                     }

                    for (int i = 0; i < inventory1.Items.Count; i++)
                    {
                        inventory1.SetItemCheckState(i, CheckState.Unchecked);
                    }
                     break;
                case "remove":
                    bool anyCheckedItems = false;
                    try
                    {
                        for (int i = 0; i < cBoxShoppingCart.Items.Count; i++)
                        {
                            if (cBoxShoppingCart.GetItemChecked(i))
                            {
                                cBoxShoppingCart.Items.RemoveAt(i);
                                anyCheckedItems = true;
                            }
                        }
                                   
                        if (anyCheckedItems == false){
                            MessageBox.Show("Check item(s) from the Shopping Cart to remove them", "Error");
                        }
                    }
                    catch
                    {
                    }
                    break;
                case "clear":
                    cBoxShoppingCart.Items.Clear();
                    break;
                case "checkOut":
                    try
                    {
                        decimal orderTotal = 0M;
                        foreach (string line in cBoxShoppingCart.Items)
                        {
                            int start = line.IndexOf("(");
                            int end = line.IndexOf(")");
                            // gets items price and adds to total
                            orderTotal += Convert.ToDecimal(line.Substring(start + 1, end - start - 1));

                        }

                        // apply discount
                        try
                        {

                            // set extended total
                            lblExtendedTotal.Text = String.Format("Extended Total:   {0:C}", orderTotal);

                            orderTotal -= Convert.ToDecimal(txtBoxDiscount.Text);
                            
                        }
                        catch
                        {
                            MessageBox.Show("Discount must be a valid number", "Error");
                            break;
                        }


                        // set order total
                        lblOrderTotal.Text = String.Format("Order Total:   {0:C}", orderTotal);
                        // set tax
                        lblTaxTotal.Text = String.Format("Tax ({0}%):   {1:C}", salesTax, orderTotal * salesTax);
                        // set grand total
                        lblGrandTotal.Text = String.Format("Grand Total:   {0:C}", orderTotal + orderTotal * salesTax);
                        // add to Sales Record
                        string record = String.Format("Grand Total: {0:C} | Timestamp: {1} ", orderTotal + orderTotal * salesTax, DateTime.Now);
                        salesRecord1.salesRecord.Add(record);

                    }
                    catch { MessageBox.Show("Error", ""); }
                    break;
            }
            updateRecords();
        }
        private void showHelp()
        {
            MessageBox.Show(
                    "Basic Functions:\n" +
                    "> Select items by clicking on check box\n" +
                    "> Add items to list using the '+' button\n" +
                    "> Remove items by using a '-' button\n" +
                    "> Enter discount by using dicount check box\n" +
                    "> Press Check Out button to add up order\n" +
                    "> Print receipt by clicking the Print button\n" +
                    "\n" +
                    "For addional help ask a manager or visit:\n" +
                    "      http://priceChopper.com/poshelp", "Help");

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            changeShoppingList("add");
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
              changeShoppingList("remove");
        }

        private void btnClearList_Click_1(object sender, EventArgs e)
        {
            changeShoppingList("clear");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            changeShoppingList("checkOut");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printReceipt();
        }

        private void viewRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showRecords();
        }

        private void refundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refundOrder();
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            refundOrder();
        }

        private void lookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lookup();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showHelp();
        }   
    }
}
