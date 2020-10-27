namespace StoreManagement
{
    partial class F_NewUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nb_accessLevel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pb_photo = new System.Windows.Forms.PictureBox();
            this.btn_addPhoto = new System.Windows.Forms.Button();
            this.pickPhoto = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_accessLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 31);
            this.panel1.TabIndex = 27;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(256, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Location = new System.Drawing.Point(15, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Access level";
            // 
            // nb_accessLevel
            // 
            this.nb_accessLevel.Location = new System.Drawing.Point(15, 118);
            this.nb_accessLevel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nb_accessLevel.Name = "nb_accessLevel";
            this.nb_accessLevel.Size = new System.Drawing.Size(100, 20);
            this.nb_accessLevel.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Username";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(15, 20);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(206, 20);
            this.tb_name.TabIndex = 17;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(121, 71);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 16;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(15, 71);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 20);
            this.tb_username.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Location = new System.Drawing.Point(96, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pb_photo
            // 
            this.pb_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_photo.Location = new System.Drawing.Point(244, 53);
            this.pb_photo.Name = "pb_photo";
            this.pb_photo.Size = new System.Drawing.Size(94, 126);
            this.pb_photo.TabIndex = 29;
            this.pb_photo.TabStop = false;
            // 
            // btn_addPhoto
            // 
            this.btn_addPhoto.Location = new System.Drawing.Point(250, 18);
            this.btn_addPhoto.Name = "btn_addPhoto";
            this.btn_addPhoto.Size = new System.Drawing.Size(81, 23);
            this.btn_addPhoto.TabIndex = 30;
            this.btn_addPhoto.Text = "Add photo";
            this.btn_addPhoto.UseVisualStyleBackColor = true;
            this.btn_addPhoto.Click += new System.EventHandler(this.btn_addPhoto_Click);
            // 
            // pickPhoto
            // 
            this.pickPhoto.FileName = "openFileDialog1";
            // 
            // F_NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 235);
            this.Controls.Add(this.btn_addPhoto);
            this.Controls.Add(this.pb_photo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nb_accessLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New user";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nb_accessLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nb_accessLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.PictureBox pb_photo;
        private System.Windows.Forms.Button btn_addPhoto;
        private System.Windows.Forms.OpenFileDialog pickPhoto;
    }
}