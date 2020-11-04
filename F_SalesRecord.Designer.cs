namespace StoreManagement
{
    partial class F_SalesRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ntb_id = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_sales = new System.Windows.Forms.DataGridView();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // ntb_id
            // 
            this.ntb_id.InterceptArrowKeys = false;
            this.ntb_id.Location = new System.Drawing.Point(29, 12);
            this.ntb_id.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ntb_id.Name = "ntb_id";
            this.ntb_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ntb_id.Size = new System.Drawing.Size(90, 20);
            this.ntb_id.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // dgv_sales
            // 
            this.dgv_sales.AllowUserToAddRows = false;
            this.dgv_sales.AllowUserToDeleteRows = false;
            this.dgv_sales.AllowUserToResizeColumns = false;
            this.dgv_sales.AllowUserToResizeRows = false;
            this.dgv_sales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales.EnableHeadersVisualStyles = false;
            this.dgv_sales.Location = new System.Drawing.Point(125, 12);
            this.dgv_sales.MultiSelect = false;
            this.dgv_sales.Name = "dgv_sales";
            this.dgv_sales.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sales.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_sales.RowHeadersVisible = false;
            this.dgv_sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sales.Size = new System.Drawing.Size(484, 424);
            this.dgv_sales.TabIndex = 20;
            this.dgv_sales.TabStop = false;
            this.dgv_sales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sales_CellContentClick);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(8, 67);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(111, 23);
            this.btn_print.TabIndex = 18;
            this.btn_print.Text = "Print voucher";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(8, 38);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(111, 23);
            this.btn_find.TabIndex = 17;
            this.btn_find.Text = "Find sale";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(8, 413);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(111, 23);
            this.btn_return.TabIndex = 23;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // F_SalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 445);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.ntb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_sales);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_SalesRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Archive";
            this.Load += new System.EventHandler(this.F_SalesRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ntb_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ntb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_sales;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}