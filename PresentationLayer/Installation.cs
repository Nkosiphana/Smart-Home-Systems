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
    public partial class Installation : Form
    {
        MenuForm MenuClass = new MenuForm();
        BindingSource bs = new BindingSource();
        Installation installationClass = new Installation();
        MaintenanceDepartment MaintenanceClasss = new MaintenanceDepartment();
        public Installation()
        {
            InitializeComponent();
        }

        private void BackLbl_Click(object sender, EventArgs e)
        {
            MenuClass.Show();
            this.Hide();
        }

        private void Installation_Load(object sender, EventArgs e)
        {
            bs.DataSource = MaintenanceClasss.GetMaintenance();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bs;
        }
    }
}
