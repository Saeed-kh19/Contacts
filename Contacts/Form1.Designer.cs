namespace Contacts
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsContacts = new System.Windows.Forms.ToolStrip();
            this.btnAddContact = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnDarkLightMode = new System.Windows.Forms.ToolStripButton();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpContacts = new System.Windows.Forms.GroupBox();
            this.dgContacts = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FavoriteFoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFavoriteFoods = new System.Windows.Forms.Button();
            this.tsContacts.SuspendLayout();
            this.gpSearch.SuspendLayout();
            this.gpContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // tsContacts
            // 
            this.tsContacts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsContacts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddContact,
            this.toolStripSeparator1,
            this.btnRefresh,
            this.btnDarkLightMode});
            this.tsContacts.Location = new System.Drawing.Point(0, 0);
            this.tsContacts.Name = "tsContacts";
            this.tsContacts.Size = new System.Drawing.Size(764, 25);
            this.tsContacts.TabIndex = 0;
            this.tsContacts.Text = "toolStrip1";
            // 
            // btnAddContact
            // 
            this.btnAddContact.Image = ((System.Drawing.Image)(resources.GetObject("btnAddContact.Image")));
            this.btnAddContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(94, 22);
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDarkLightMode
            // 
            this.btnDarkLightMode.Image = ((System.Drawing.Image)(resources.GetObject("btnDarkLightMode.Image")));
            this.btnDarkLightMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDarkLightMode.Name = "btnDarkLightMode";
            this.btnDarkLightMode.Size = new System.Drawing.Size(117, 22);
            this.btnDarkLightMode.Text = "Dark/Light Mode";
            this.btnDarkLightMode.Click += new System.EventHandler(this.btnDarkLightMode_Click);
            // 
            // gpSearch
            // 
            this.gpSearch.Controls.Add(this.txtSearchNumber);
            this.gpSearch.Controls.Add(this.label2);
            this.gpSearch.Controls.Add(this.txtSearchName);
            this.gpSearch.Controls.Add(this.label1);
            this.gpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSearch.Location = new System.Drawing.Point(12, 28);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(740, 66);
            this.gpSearch.TabIndex = 1;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Search";
            // 
            // txtSearchNumber
            // 
            this.txtSearchNumber.Location = new System.Drawing.Point(501, 27);
            this.txtSearchNumber.Name = "txtSearchNumber";
            this.txtSearchNumber.Size = new System.Drawing.Size(233, 20);
            this.txtSearchNumber.TabIndex = 3;
            this.txtSearchNumber.TextChanged += new System.EventHandler(this.txtSearchNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search by phone number : ";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(102, 27);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(235, 20);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by name :";
            // 
            // gpContacts
            // 
            this.gpContacts.Controls.Add(this.dgContacts);
            this.gpContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpContacts.Location = new System.Drawing.Point(12, 100);
            this.gpContacts.Name = "gpContacts";
            this.gpContacts.Size = new System.Drawing.Size(740, 293);
            this.gpContacts.TabIndex = 4;
            this.gpContacts.TabStop = false;
            this.gpContacts.Text = "Contacts";
            // 
            // dgContacts
            // 
            this.dgContacts.AllowUserToAddRows = false;
            this.dgContacts.AllowUserToDeleteRows = false;
            this.dgContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgContacts.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ContactName,
            this.Mobile,
            this.Email,
            this.Age,
            this.Address,
            this.FavoriteFoodId,
            this.Food});
            this.dgContacts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgContacts.Location = new System.Drawing.Point(9, 19);
            this.dgContacts.MultiSelect = false;
            this.dgContacts.Name = "dgContacts";
            this.dgContacts.ReadOnly = true;
            this.dgContacts.Size = new System.Drawing.Size(725, 268);
            this.dgContacts.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(21, 398);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(125)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(102, 398);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "contactID";
            this.ID.HeaderText = "ContactID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "name";
            this.ContactName.FillWeight = 99.61929F;
            this.ContactName.HeaderText = "Name";
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "PhoneNumber";
            this.Mobile.FillWeight = 99.61929F;
            this.Mobile.HeaderText = "Phone Number";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.FillWeight = 99.61929F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "age";
            this.Age.FillWeight = 101.5229F;
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            this.Address.FillWeight = 99.61929F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // FavoriteFoodId
            // 
            this.FavoriteFoodId.DataPropertyName = "Id";
            this.FavoriteFoodId.HeaderText = "FavoriteFoodId";
            this.FavoriteFoodId.Name = "FavoriteFoodId";
            this.FavoriteFoodId.ReadOnly = true;
            this.FavoriteFoodId.Visible = false;
            // 
            // Food
            // 
            this.Food.DataPropertyName = "foodName";
            this.Food.HeaderText = "Favorite Food";
            this.Food.Name = "Food";
            this.Food.ReadOnly = true;
            // 
            // btnFavoriteFoods
            // 
            this.btnFavoriteFoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnFavoriteFoods.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFavoriteFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavoriteFoods.Location = new System.Drawing.Point(671, 398);
            this.btnFavoriteFoods.Name = "btnFavoriteFoods";
            this.btnFavoriteFoods.Size = new System.Drawing.Size(75, 23);
            this.btnFavoriteFoods.TabIndex = 6;
            this.btnFavoriteFoods.Text = "More";
            this.btnFavoriteFoods.UseVisualStyleBackColor = false;
            this.btnFavoriteFoods.Click += new System.EventHandler(this.btnFavoriteFoods_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(764, 433);
            this.Controls.Add(this.btnFavoriteFoods);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gpContacts);
            this.Controls.Add(this.gpSearch);
            this.Controls.Add(this.tsContacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsContacts.ResumeLayout(false);
            this.tsContacts.PerformLayout();
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            this.gpContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsContacts;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton btnAddContact;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnDarkLightMode;
        private System.Windows.Forms.GroupBox gpContacts;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn FavoriteFoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food;
        private System.Windows.Forms.Button btnFavoriteFoods;
    }
}

