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
    public partial class frmFoods : Form
    {
        IContactsRepository repository;
        public int darkLightModeCounter = 0;
        public int contactId = 0;
        public int editStatus = 0;

        public frmFoods()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }

        private void frmFoods_Load(object sender, EventArgs e)
        {
            DataTable dt = repository.SelectRow(contactId);
            try
            {
                txtFavoriteFoods.Text = dt.Rows[0][8].ToString();
                editStatus = 1;
            }
            catch (Exception)
            {
                editStatus = 0;
            }

            if (editStatus == 0)
            {
                btnSubmit.Text = "Submit";
            }
            else
            {
                btnSubmit.Text = "Edit";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (editStatus == 0)
            {
                var isSuccess = repository.InsertFood(txtFavoriteFoods.Text, contactId);
                if (isSuccess)
                {
                    MessageBox.Show("Food added successfuly", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Operation Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var isSuccess = repository.UpdateFood(txtFavoriteFoods.Text, contactId);
                if (isSuccess)
                {
                    MessageBox.Show("Food added successfuly", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Operation Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
