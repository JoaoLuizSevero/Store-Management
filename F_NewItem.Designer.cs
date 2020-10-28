namespace StoreManagement
{
    partial class F_NewItem
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
            this.btn_addPhoto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nb_stock = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.lb_model = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_color = new System.Windows.Forms.TextBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.pickImage = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.nb_price = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_price)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addPhoto
            // 
            this.btn_addPhoto.Location = new System.Drawing.Point(243, 166);
            this.btn_addPhoto.Name = "btn_addPhoto";
            this.btn_addPhoto.Size = new System.Drawing.Size(135, 23);
            this.btn_addPhoto.TabIndex = 5;
            this.btn_addPhoto.Text = "Add photo";
            this.btn_addPhoto.UseVisualStyleBackColor = true;
            this.btn_addPhoto.Click += new System.EventHandler(this.btn_addPhoto_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 31);
            this.panel1.TabIndex = 38;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(280, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(96, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Location = new System.Drawing.Point(12, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(96, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Stock";
            // 
            // nb_stock
            // 
            this.nb_stock.Location = new System.Drawing.Point(135, 70);
            this.nb_stock.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nb_stock.Name = "nb_stock";
            this.nb_stock.Size = new System.Drawing.Size(87, 20);
            this.nb_stock.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Price";
            // 
            // tb_model
            // 
            this.tb_model.Location = new System.Drawing.Point(12, 27);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(210, 20);
            this.tb_model.TabIndex = 0;
            this.tb_model.TextChanged += new System.EventHandler(this.tb_model_TextChanged);
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(13, 117);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(209, 20);
            this.tb_description.TabIndex = 3;
            // 
            // lb_model
            // 
            this.lb_model.AutoSize = true;
            this.lb_model.Location = new System.Drawing.Point(9, 11);
            this.lb_model.Name = "lb_model";
            this.lb_model.Size = new System.Drawing.Size(36, 13);
            this.lb_model.TabIndex = 34;
            this.lb_model.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Color";
            // 
            // tb_color
            // 
            this.tb_color.Location = new System.Drawing.Point(13, 163);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(209, 20);
            this.tb_color.TabIndex = 4;
            // 
            // pb_image
            // 
            this.pb_image.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pb_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_image.Location = new System.Drawing.Point(243, 25);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(135, 135);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 39;
            this.pb_image.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "R$";
            // 
            // nb_price
            // 
            this.nb_price.Location = new System.Drawing.Point(39, 70);
            this.nb_price.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nb_price.Name = "nb_price";
            this.nb_price.Size = new System.Drawing.Size(77, 20);
            this.nb_price.TabIndex = 1;
            // 
            // F_NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 245);
            this.Controls.Add(this.nb_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_color);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.btn_addPhoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nb_stock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_model);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.lb_model);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Item";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nb_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Button btn_addPhoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nb_stock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lb_model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_color;
        private System.Windows.Forms.OpenFileDialog pickImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nb_price;
    }
}