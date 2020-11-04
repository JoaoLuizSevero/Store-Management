using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class F_SalesManagement : Form
    {
        Int32 totalPrice = 0;

        public F_SalesManagement()
        {
            InitializeComponent();
            ntb_id.Controls.RemoveAt(0);
            dgv_items.Columns[0].Width = 150;
            dgv_items.Columns[1].Width = 70;
            dgv_items.Columns[2].Width = 90;
            lb_operator.Text = Globals.userLogged;
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable itemData;
                itemData = Db.GetPerId(Convert.ToInt32(ntb_id.Value), "items");

                string model = itemData.Rows[0].Field<string>("T_MODEL");
                Int32 stock = Convert.ToInt32(itemData.Rows[0].Field<Int64>("N_QUANTITY"));
                Int32 price = Convert.ToInt32(itemData.Rows[0].Field<string>("T_PRICE"));
                if (dgv_items.Rows.Count > 0)
                {
                    for (Int32 i = 0; i < dgv_items.Rows.Count; i++)
                    {
                        if (dgv_items.Rows[i].Cells[0].Value.ToString() == model)
                        {
                            Int32 clientQuantity = Convert.ToInt32(dgv_items.Rows[i].Cells[1].Value);
                            if (stock > clientQuantity)
                            {
                                clientQuantity++;
                                dgv_items.Rows[i].Cells[1].Value = clientQuantity;
                                calcTotalPrice(Convert.ToInt32(price));
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Item out of stock!");
                                return;
                            }
                        }
                    }
                    if (stock > 0)
                    {
                        dgv_items.Rows.Add(model, 1, price);
                        calcTotalPrice(Convert.ToInt32(price));
                    }
                    else
                    {
                        MessageBox.Show("Item out of stock!");
                    }
                }
                else
                {
                    if (stock > 0)
                    {
                        dgv_items.Rows.Add(model, 1, price);
                        calcTotalPrice(Convert.ToInt32(price));
                    }
                    else
                    {
                        MessageBox.Show("Item out of stock!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Item not found!");
            }
            ntb_id.Value = 0;
        }

        private void calcTotalPrice(Int32 value)
        {
            totalPrice += value;
            lb_total.Text = totalPrice.ToString() + ",00";
        }

        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove '"+ dgv_items.CurrentRow.Cells[0].Value.ToString() + "'?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Int32 price = Convert.ToInt32(dgv_items.CurrentRow.Cells[2].Value);
                Int32 quantity = Convert.ToInt32(dgv_items.CurrentRow.Cells[1].Value);
                calcTotalPrice(Convert.ToInt32(price * -1));
                if(quantity == 1)
                {
                    dgv_items.Rows.Remove(dgv_items.CurrentRow);
                }
                else
                {
                    dgv_items.CurrentRow.Cells[1].Value = Convert.ToInt32(dgv_items.CurrentRow.Cells[1].Value)-1; 
                }
            }
        }
        private void btn_finish_Click(object sender, EventArgs e)
        {
            Sale newSale = new Sale();
            newSale.value = totalPrice;
            newSale.date = DateTime.Today.ToString();
            string message = newSale.date + "\nPurchase nº: " + "10" + "\nOperator: "+ Globals.userLogged +"\n------------------------------\nItems:\n";
            for (Int32 i = 0; i < dgv_items.Rows.Count; i++)
            {
                string model = dgv_items.Rows[i].Cells[0].Value.ToString();
                string quantity = dgv_items.Rows[i].Cells[1].Value.ToString();
                string price = dgv_items.Rows[i].Cells[2].Value.ToString();
                message += quantity + " " + model + " = R$ " + price + ",00\n";
            }
            message += "------------------------------\nTotal: R$ " + totalPrice + ",00";
            newSale.description = message;
            newSale.user = Globals.userLogged;
            string message2 = "\n\n\nConfirm purchase?";
            if (MessageBox.Show(message + message2, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (Int32 i = 0; i < dgv_items.Rows.Count; i++)
                {
                    string model = dgv_items.Rows[i].Cells[0].Value.ToString();
                    Int32 quantity = Convert.ToInt32(dgv_items.Rows[i].Cells[1].Value);
                    Int32 stock = Db.GetItemStock(model);
                    Db.ChangeItemQuantity(stock - quantity > 0 ? stock - quantity : 0, model);
                    dgv_items.Rows.Remove(dgv_items.Rows[i]);
                }
                Db.RegisterSale(newSale);
                if (MessageBox.Show("Purchase confirmed!\n\nPrint voucher?", "Voucher", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { 


                }
            }
        }

        private void F_SalesManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (Int32 i = 0; i < dgv_items.Rows.Count; i++)
            {
                dgv_items.Rows.Remove(dgv_items.Rows[i]);
            }
            ntb_id.Value = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really want to close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (Int32 i = 0; i < dgv_items.Rows.Count; i++)
                {
                    dgv_items.Rows.Remove(dgv_items.Rows[i]);
                }
                ntb_id.Value = 0;
                Close();
            }
        }
    }
}
