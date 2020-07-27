using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayers;

namespace Moyo_Vincent_PracticalAssignment
{
    public partial class Developers : Form
    {
        DevelopersManagement DevelopersClass = new DevelopersManagement();
        BindingSource bs = new BindingSource();
        public Developers()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
           
        }

        private void BackLbl_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void Developers_Load(object sender, EventArgs e)
        {
            bs.DataSource = DevelopersClass.GetDevelopers();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bs;
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DevelopersManagement developerclass = (DevelopersManagement)dataGridView1.CurrentRow.DataBoundItem;
            IDLBL.Text = developerclass.DeveloperID1.ToString();
            firstNameLBL.Text = developerclass.Name;
            lastNameLBL.Text = developerclass.LastName;
            contactInfoLBL.Text = developerclass.Contact.ToString();
            EmailLBL.Text = developerclass.Email;
            specilizeLBL.Text = developerclass.Speciality;
            descriptionLBL.Text = developerclass.Description;
        }

        private void MoveFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void MovePrevious_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void MoveNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void MoveLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void ContactBTN_Click(object sender, EventArgs e)
        {
            string name = firstNameLBL.Text;
            int contact = int.Parse(contactInfoLBL.Text);
            MessageBox.Show("Calling " + name + "\nCellphone number: " + contact, "Calling " + name, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = firstNameLBL.Text;
            string email = EmailLBL.Text;
            MessageBox.Show(@"Opening mailbox to compose email to " + name +
                " \nEmail: " + email, "Emailing " + name, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
