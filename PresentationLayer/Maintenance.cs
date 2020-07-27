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
    public partial class Maintenance : Form
    {
        MenuForm MenuClass = new MenuForm();
        BindingSource bs = new BindingSource();
        MaintenanceDepartment MaintenanceClasss = new MaintenanceDepartment();

        public Maintenance()
        {
            InitializeComponent();
        }

        private void BackLbl_Click(object sender, EventArgs e)
        {
            MenuClass.Show();
            this.Hide();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            bs.DataSource = MaintenanceClasss.GetMaintenance();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bs;
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

        int maintenanceID;
        string maintenanceType;
        string maintainDescription;
        DateTime installationDate;


        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            MaintenanceDepartment maintainClass = (MaintenanceDepartment)dataGridView1.CurrentRow.DataBoundItem;
            maintenanceID = maintainClass.MaintenanceID;
            maintenanceType = maintainClass.MaintenanceType;
            maintainDescription = maintainClass.MaintainDescription;
            installationDate = maintainClass.InstallationDate;
        }
        private void MaintainBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Maintenance confirmed for Porduct: " + maintenanceID +
                "\nProductType: " + maintenanceType +
                "\nProduct Description: " + maintainDescription, "Maintenance initiated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
