namespace StoreManagement
{
    partial class F_ItemManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_newItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_items
            // 
            this.dgv_items.AllowUserToAddRows = false;
            this.dgv_items.AllowUserToDeleteRows = false;
            this.dgv_items.AllowUserToResizeColumns = false;
            this.dgv_items.AllowUserToResizeRows = false;
            this.dgv_items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.EnableHeadersVisualStyles = false;
            this.dgv_items.Location = new System.Drawing.Point(115, 12);
            this.dgv_items.MultiSelect = false;
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_items.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_items.RowHeadersVisible = false;
            this.dgv_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_items.Size = new System.Drawing.Size(500, 200);
            this.dgv_items.TabIndex = 13;
            this.dgv_items.TabStop = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(7, 79);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(102, 23);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Edit item";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_editItem_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(7, 50);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(102, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete item";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(7, 184);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(102, 23);
            this.btn_return.TabIndex = 12;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_newItem
            // 
            this.btn_newItem.Location = new System.Drawing.Point(7, 21);
            this.btn_newItem.Name = "btn_newItem";
            this.btn_newItem.Size = new System.Drawing.Size(102, 23);
            this.btn_newItem.TabIndex = 9;
            this.btn_newItem.Text = "New item";
            this.btn_newItem.UseVisualStyleBackColor = true;
            this.btn_newItem.Click += new System.EventHandler(this.btn_newItem_Click);
            // 
            // F_ItemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 219);
            this.Controls.Add(this.dgv_items);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_newItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ItemManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Management";
            this.Load += new System.EventHandler(this.F_ItemManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_items;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_newItem;
    }
}