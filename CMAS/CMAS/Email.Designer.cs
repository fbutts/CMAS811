namespace CMAS
{
    partial class Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.btnSend = new System.Windows.Forms.Button();
            this.RecEmail = new System.Windows.Forms.TextBox();
            this.SubEmail = new System.Windows.Forms.TextBox();
            this.BodyEmail = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.Label();
            this.PassEmail = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbEmailAdd = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(843, 498);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // RecEmail
            // 
            this.RecEmail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.RecEmail.Location = new System.Drawing.Point(83, 534);
            this.RecEmail.Name = "RecEmail";
            this.RecEmail.Size = new System.Drawing.Size(587, 20);
            this.RecEmail.TabIndex = 1;
            // 
            // SubEmail
            // 
            this.SubEmail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SubEmail.Location = new System.Drawing.Point(83, 240);
            this.SubEmail.Name = "SubEmail";
            this.SubEmail.Size = new System.Drawing.Size(587, 20);
            this.SubEmail.TabIndex = 2;
            // 
            // BodyEmail
            // 
            this.BodyEmail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BodyEmail.Location = new System.Drawing.Point(13, 270);
            this.BodyEmail.Multiline = true;
            this.BodyEmail.Name = "BodyEmail";
            this.BodyEmail.Size = new System.Drawing.Size(905, 180);
            this.BodyEmail.TabIndex = 3;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(13, 541);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 13);
            this.Status.TabIndex = 4;
            // 
            // PassEmail
            // 
            this.PassEmail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PassEmail.Location = new System.Drawing.Point(712, 472);
            this.PassEmail.Name = "PassEmail";
            this.PassEmail.Size = new System.Drawing.Size(206, 20);
            this.PassEmail.TabIndex = 5;
            this.PassEmail.Text = "Enter Email Password";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(712, 498);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SUBJECT:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(676, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cbEmailAdd
            // 
            this.cbEmailAdd.FormattingEnabled = true;
            this.cbEmailAdd.Location = new System.Drawing.Point(83, 12);
            this.cbEmailAdd.Name = "cbEmailAdd";
            this.cbEmailAdd.Size = new System.Drawing.Size(587, 214);
            this.cbEmailAdd.TabIndex = 10;
            // 
            // Email
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 587);
            this.Controls.Add(this.cbEmailAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.PassEmail);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.BodyEmail);
            this.Controls.Add(this.SubEmail);
            this.Controls.Add(this.RecEmail);
            this.Controls.Add(this.btnSend);
            this.Name = "Email";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox RecEmail;
        private System.Windows.Forms.TextBox SubEmail;
        private System.Windows.Forms.TextBox BodyEmail;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox PassEmail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox cbEmailAdd;
    }
}