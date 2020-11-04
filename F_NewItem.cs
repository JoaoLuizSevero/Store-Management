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
    public partial class F_NewItem : Form
    {
        string id;
        public F_NewItem(string incomingId)
        {
            InitializeComponent();
            id = incomingId;
            if (id != "new")
            {
                this.Text = "Edit item";
                DataTable table;
                table = Db.GetPerId(Int32.Parse(id),"items");
                tb_model.Text = table.Rows[0].Field<string>("T_MODEL");
                nb_price.Text = table.Rows[0].Field<string>("T_PRICE");
                nb_stock.Value = table.Rows[0].Field<Int64>("N_QUANTITY");
                tb_description.Text = table.Rows[0].Field<string>("T_DESCRIPTION");
                tb_color.Text = table.Rows[0].Field<string>("T_COLOR");
                pb_image.ImageLocation = table.Rows[0].Field<string>("T_IMAGE");
            }
            else
            {
                btn_save.Enabled = false;
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            Item thisItem = new Item();
            thisItem.model = tb_model.Text;
            thisItem.price = nb_price.Text;
            thisItem.stock = Convert.ToInt32(nb_stock.Value);
            thisItem.description = tb_description.Text;
            thisItem.color = tb_color.Text;
            thisItem.image = pb_image.ImageLocation;
            if (pb_image.ImageLocation == "" || pb_image.ImageLocation == null)
            {
                if (MessageBox.Show("No image added! \nProceed?", "No image added", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            if (id != "new")
            {
                Db.SaveItem(thisItem, id);
            }
            else
            {
                Db.SaveItem(thisItem, null);
            }
            btn_cancel_Click(this, null);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_model.Text = "";
            nb_price.Text = "";
            nb_stock.Value = 0;
            tb_description.Text = "";
            tb_color.Text = "";
            pb_image.ImageLocation = null;
            Close();
        }

        private void btn_addPhoto_Click(object sender, EventArgs e)
        {
            this.pickImage.Title = "Choose an Image";
            pickImage.FileName = "";
            pickImage.InitialDirectory = @"Desktop";
            pickImage.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (pickImage.ShowDialog() == DialogResult.OK)
            {
                pb_image.ImageLocation = pickImage.FileName;
            }
        }

        private void tb_model_TextChanged(object sender, EventArgs e)
        {
            validateSaveButton();
        }
        private void nb_price_TextChanged(object sender, EventArgs e)
        {
            validateSaveButton();
        }

        private void validateSaveButton()
        {
            if (tb_model.Text != "" && nb_price.Text != "")
            {
                btn_save.Enabled = true;
            }
            else
            {
                btn_save.Enabled = false;
            }
        }

    }
}
