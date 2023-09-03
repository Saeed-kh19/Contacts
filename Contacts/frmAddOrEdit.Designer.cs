namespace Contacts
{
    partial class frmAddOrEdit
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
            this.gpName = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gpPhoneNumber = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.gpEmail = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gpAge = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.NumericUpDown();
            this.gpAddress = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gpName.SuspendLayout();
            this.gpPhoneNumber.SuspendLayout();
            this.gpEmail.SuspendLayout();
            this.gpAge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).BeginInit();
            this.gpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpName
            // 
            this.gpName.Controls.Add(this.label1);
            this.gpName.Controls.Add(this.txtName);
            this.gpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpName.Location = new System.Drawing.Point(12, 12);
            this.gpName.Name = "gpName";
            this.gpName.Size = new System.Drawing.Size(551, 48);
            this.gpName.TabIndex = 0;
            this.gpName.TabStop = false;
            this.gpName.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(-4, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "*";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(539, 20);
            this.txtName.TabIndex = 0;
            // 
            // gpPhoneNumber
            // 
            this.gpPhoneNumber.Controls.Add(this.label2);
            this.gpPhoneNumber.Controls.Add(this.txtNumber);
            this.gpPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPhoneNumber.Location = new System.Drawing.Point(12, 66);
            this.gpPhoneNumber.Name = "gpPhoneNumber";
            this.gpPhoneNumber.Size = new System.Drawing.Size(551, 48);
            this.gpPhoneNumber.TabIndex = 1;
            this.gpPhoneNumber.TabStop = false;
            this.gpPhoneNumber.Text = "Phone number : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(-4, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "*";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(6, 19);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(539, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // gpEmail
            // 
            this.gpEmail.Controls.Add(this.label4);
            this.gpEmail.Controls.Add(this.txtEmail);
            this.gpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEmail.Location = new System.Drawing.Point(12, 123);
            this.gpEmail.Name = "gpEmail";
            this.gpEmail.Size = new System.Drawing.Size(551, 48);
            this.gpEmail.TabIndex = 5;
            this.gpEmail.TabStop = false;
            this.gpEmail.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(-4, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "*";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 19);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(539, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // gpAge
            // 
            this.gpAge.Controls.Add(this.label3);
            this.gpAge.Controls.Add(this.txtAge);
            this.gpAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpAge.Location = new System.Drawing.Point(12, 174);
            this.gpAge.Name = "gpAge";
            this.gpAge.Size = new System.Drawing.Size(551, 48);
            this.gpAge.TabIndex = 2;
            this.gpAge.TabStop = false;
            this.gpAge.Text = "Age : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(-4, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "*";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(6, 19);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(539, 20);
            this.txtAge.TabIndex = 0;
            // 
            // gpAddress
            // 
            this.gpAddress.Controls.Add(this.txtAddress);
            this.gpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpAddress.Location = new System.Drawing.Point(12, 228);
            this.gpAddress.Name = "gpAddress";
            this.gpAddress.Size = new System.Drawing.Size(551, 142);
            this.gpAddress.TabIndex = 5;
            this.gpAddress.TabStop = false;
            this.gpAddress.Text = "Address : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(6, 19);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(539, 111);
            this.txtAddress.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(101)))), ((int)(((byte)(243)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(12, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(93, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 408);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gpEmail);
            this.Controls.Add(this.gpAddress);
            this.Controls.Add(this.gpPhoneNumber);
            this.Controls.Add(this.gpAge);
            this.Controls.Add(this.gpName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddOrEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAddOrEdit_Load);
            this.gpName.ResumeLayout(false);
            this.gpName.PerformLayout();
            this.gpPhoneNumber.ResumeLayout(false);
            this.gpPhoneNumber.PerformLayout();
            this.gpEmail.ResumeLayout(false);
            this.gpEmail.PerformLayout();
            this.gpAge.ResumeLayout(false);
            this.gpAge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).EndInit();
            this.gpAddress.ResumeLayout(false);
            this.gpAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gpName;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.GroupBox gpPhoneNumber;
        public System.Windows.Forms.TextBox txtNumber;
        public System.Windows.Forms.GroupBox gpEmail;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.GroupBox gpAge;
        public System.Windows.Forms.NumericUpDown txtAge;
        public System.Windows.Forms.GroupBox gpAddress;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}