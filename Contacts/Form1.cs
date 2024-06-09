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
    public partial class Form1 : Form
    {
        IContactsRepository repository;
        public int darkLightModeCounter = 0;
        public Form1()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frm = new frmAddOrEdit(); //factory algorithm
            if (darkLightModeCounter % 2 != 0)
            {
                frm.BackColor= SystemColors.WindowFrame;
                frm.txtName.BackColor= SystemColors.ControlDark;
                frm.txtNumber.BackColor= SystemColors.ControlDark;
                frm.txtEmail.BackColor= SystemColors.ControlDark;
                frm.txtAge.BackColor= SystemColors.ControlDark;
                frm.txtAddress.BackColor= SystemColors.ControlDark;
                frm.gpName.ForeColor= SystemColors.ControlLightLight;
                frm.gpPhoneNumber.ForeColor= SystemColors.ControlLightLight;
                frm.gpEmail.ForeColor= SystemColors.ControlLightLight;
                frm.gpAge.ForeColor= SystemColors.ControlLightLight;
                frm.gpAddress.ForeColor= SystemColors.ControlLightLight;
            }
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgContacts.AutoGenerateColumns = false;
            dgContacts.Columns[0].Visible = false;
            dgContacts.DataSource = repository.showAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = dgContacts.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show("Are you sure to delete '" + name + "'", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
                repository.Delete(contactId);
                BindGrid();
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            dgContacts.DataSource = repository.Search(txtSearchName.Text);
        }

        private void txtSearchNumber_TextChanged(object sender, EventArgs e)
        {
            dgContacts.DataSource = repository.SearchPhone(txtSearchNumber.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
            frmAddOrEdit frm = new frmAddOrEdit();
            frm.contactId = contactId;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnDarkLightMode_Click(object sender, EventArgs e)
        {
            darkLightModeCounter++;
            frmAddOrEdit frm = new frmAddOrEdit();
            if (darkLightModeCounter % 2 != 0)
            {
                this.BackColor = SystemColors.WindowFrame;
                dgContacts.BackgroundColor = SystemColors.ControlDark;
                dgContacts.ForeColor = Color.Black;
                gpSearch.ForeColor = SystemColors.ControlLightLight;
                gpContacts.ForeColor = SystemColors.ControlLightLight;
                txtSearchName.BackColor = SystemColors.ScrollBar;
                txtSearchNumber.BackColor = SystemColors.ScrollBar;
                tsContacts.BackColor = SystemColors.ControlDark;
                //btnDelete.Font.Bold = true;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                dgContacts.BackgroundColor = SystemColors.ScrollBar;
                dgContacts.ForeColor = Color.Black;
                gpSearch.ForeColor = Color.Black;
                gpContacts.ForeColor = Color.Black;
                txtSearchName.BackColor = SystemColors.Window;
                txtSearchNumber.BackColor = SystemColors.Window;
                tsContacts.BackColor = SystemColors.Control;
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());

        }
    }
}
