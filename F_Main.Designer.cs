namespace StoreManagement
{
    partial class F_Main
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
            this.lb_user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_photo = new System.Windows.Forms.PictureBox();
            this.lb_function = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logOff = new System.Windows.Forms.Button();
            this.btn_logOn = new System.Windows.Forms.Button();
            this.btn_userManagement = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_itemManagement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_salesRecord = new System.Windows.Forms.Button();
            this.btn_salesManagement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(58, 11);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(0, 16);
            this.lb_user.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "User:";
            // 
            // pb_photo
            // 
            this.pb_photo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pb_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_photo.Location = new System.Drawing.Point(12, 50);
            this.pb_photo.Name = "pb_photo";
            this.pb_photo.Size = new System.Drawing.Size(96, 128);
            this.pb_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_photo.TabIndex = 5;
            this.pb_photo.TabStop = false;
            // 
            // lb_function
            // 
            this.lb_function.AutoSize = true;
            this.lb_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_function.Location = new System.Drawing.Point(97, 27);
            this.lb_function.Name = "lb_function";
            this.lb_function.Size = new System.Drawing.Size(0, 16);
            this.lb_function.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Occupation:";
            // 
            // btn_logOff
            // 
            this.btn_logOff.Location = new System.Drawing.Point(12, 219);
            this.btn_logOff.Name = "btn_logOff";
            this.btn_logOff.Size = new System.Drawing.Size(96, 23);
            this.btn_logOff.TabIndex = 2;
            this.btn_logOff.Text = "LogOff";
            this.btn_logOff.UseVisualStyleBackColor = true;
            this.btn_logOff.Click += new System.EventHandler(this.btn_logoff_Click);
            // 
            // btn_logOn
            // 
            this.btn_logOn.Location = new System.Drawing.Point(12, 190);
            this.btn_logOn.Name = "btn_logOn";
            this.btn_logOn.Size = new System.Drawing.Size(96, 23);
            this.btn_logOn.TabIndex = 1;
            this.btn_logOn.Text = "LogOn";
            this.btn_logOn.UseVisualStyleBackColor = true;
            this.btn_logOn.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_userManagement
            // 
            this.btn_userManagement.Location = new System.Drawing.Point(3, 19);
            this.btn_userManagement.Name = "btn_userManagement";
            this.btn_userManagement.Size = new System.Drawing.Size(119, 24);
            this.btn_userManagement.TabIndex = 3;
            this.btn_userManagement.Text = "User Management";
            this.btn_userManagement.UseVisualStyleBackColor = true;
            this.btn_userManagement.Click += new System.EventHandler(this.btn_userManagement_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(3, 222);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(119, 24);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::StoreManagement.Properties.Resources.logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(180, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 125);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "2020 - By JoaoLuizSevero";
            // 
            // btn_itemManagement
            // 
            this.btn_itemManagement.Location = new System.Drawing.Point(3, 49);
            this.btn_itemManagement.Name = "btn_itemManagement";
            this.btn_itemManagement.Size = new System.Drawing.Size(119, 24);
            this.btn_itemManagement.TabIndex = 4;
            this.btn_itemManagement.Text = "Item Management";
            this.btn_itemManagement.UseVisualStyleBackColor = true;
            this.btn_itemManagement.Click += new System.EventHandler(this.btn_itemManagement_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_photo);
            this.panel1.Controls.Add(this.btn_logOn);
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Controls.Add(this.lb_function);
            this.panel1.Controls.Add(this.btn_logOff);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 254);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_salesRecord);
            this.panel2.Controls.Add(this.btn_salesManagement);
            this.panel2.Controls.Add(this.btn_userManagement);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.btn_itemManagement);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(351, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 254);
            this.panel2.TabIndex = 14;
            // 
            // btn_salesRecord
            // 
            this.btn_salesRecord.Location = new System.Drawing.Point(3, 79);
            this.btn_salesRecord.Name = "btn_salesRecord";
            this.btn_salesRecord.Size = new System.Drawing.Size(119, 24);
            this.btn_salesRecord.TabIndex = 5;
            this.btn_salesRecord.Text = "Sales Archive";
            this.btn_salesRecord.UseVisualStyleBackColor = true;
            this.btn_salesRecord.Click += new System.EventHandler(this.btn_salesRecord_Click);
            // 
            // btn_salesManagement
            // 
            this.btn_salesManagement.Location = new System.Drawing.Point(3, 109);
            this.btn_salesManagement.Name = "btn_salesManagement";
            this.btn_salesManagement.Size = new System.Drawing.Size(119, 24);
            this.btn_salesManagement.TabIndex = 6;
            this.btn_salesManagement.Text = "Sale Operation";
            this.btn_salesManagement.UseVisualStyleBackColor = true;
            this.btn_salesManagement.Click += new System.EventHandler(this.btn_salesManagement_Click);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 254);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual Cult - Store Management";
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_function;
        private System.Windows.Forms.Button btn_userManagement;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_logOn;
        private System.Windows.Forms.Button btn_logOff;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pb_photo;
        private System.Windows.Forms.Button btn_itemManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_salesManagement;
        private System.Windows.Forms.Button btn_salesRecord;
    }
}