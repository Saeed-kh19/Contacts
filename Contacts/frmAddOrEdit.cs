using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class frmAddOrEdit : Form
    {
        IContactsRepository repository;
        public int darkLightModeCounter = 0;
        public int contactId = 0;
        public frmAddOrEdit()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }

        bool validateInputs()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter your name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNumber.Text == "")
            {
                MessageBox.Show("Please enter your number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter your email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtAge.Text == "")
            {
                MessageBox.Show("Please enter your age!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                bool isSuccess = true;
                bool isSuccess2 = true;

                if (contactId == 0)
                {
                    isSuccess = repository.Insert(txtName.Text, txtNumber.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);
                }
                else
                {
                    isSuccess = repository.Update(contactId, txtName.Text, txtNumber.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);
                }

                if (isSuccess && isSuccess2)
                {
                    if (contactId == 0)
                    {
                        MessageBox.Show("Contact added successfuly", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                    else
                    {
                        MessageBox.Show("Contact edited successfuly", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Operation Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (darkLightModeCounter % 2 != 0)
            {
                this.BackColor = Color.Blue;
            }

            if (contactId == 0)
            {
                this.Text = "Add new contact";
            }
            else
            {
                this.Text = "Edit Contact";
                DataTable dt = repository.SelectRow(contactId);
                txtName.Text = dt.Rows[0][1].ToString();
                txtNumber.Text = dt.Rows[0][2].ToString();
                txtEmail.Text = dt.Rows[0][3].ToString();
                txtAge.Text = dt.Rows[0][4].ToString();
                txtAddress.Text = dt.Rows[0][5].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
