using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayers;


namespace Moyo_Vincent_PracticalAssignment
{
    public delegate void changeDetails();
    public partial class MenuForm : Form
    {
        //Event Declaration
        public event changeDetails onChangeDetails;

        //Declarations
        BindingSource bs = new BindingSource();
        Client clientclass = new Client();
        //Login loginclass = new Login();
        Register registerclass = new Register();
        Developers developersclass = new Developers();
        TechnicalDepartment technicalclass = new TechnicalDepartment();
        Product productclass = new Product();
       
       

        public MenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Retrieve list from client class to fill datagrid 
            bs.DataSource = clientclass.GetClients();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bs;
        }


        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // retireive the data that is cureently selected in the datagrid using the textboxes
            Client client = (Client)dataGridView1.CurrentRow.DataBoundItem;
            IDtxt.Text = client.ID1.ToString();
            FirstNametxt.Text = client.Name;
            LastNametxt.Text = client.LastName;
            Agetxt.Text = client.Age.ToString();

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            // Condition to check if all textboxes are filled
            if (FirstNametxt.Text == string.Empty || LastNametxt.Text == string.Empty || Agetxt.Text==string.Empty)
            {
                //invoke the failed update event 
                onChangeDetails += new changeDetails(failedUpdate);
                onChangeDetails.Invoke();
            }
            else
            {
                
                clientclass.ID1 = int.Parse(IDtxt.Text);
                clientclass.Name = FirstNametxt.Text;
                clientclass.LastName = LastNametxt.Text;
                clientclass.Age = int.Parse(Agetxt.Text);

                //calling the update method in the client class located in the business logic layer
                clientclass.UpdateClient(clientclass.ID1, clientclass.Name, clientclass.LastName, clientclass.Age);
                dataGridView1.DataSource = clientclass.GetClients();

                //invoke the update change event 
                onChangeDetails += new changeDetails(updateChange);
                onChangeDetails.Invoke();

            }   

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }


        private void Button5_Click(object sender, EventArgs e)
        {

            registerclass.Show();
            this.Hide();
        }


        private void DeveloperBTN_Click(object sender, EventArgs e)
        {

            developersclass.Show();
            this.Hide();
        }

        private void TechnicalBTN_Click_1(object sender, EventArgs e)
        {

            technicalclass.Show();
            this.Hide();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {

            productclass.Show();
            this.Hide();
        }

        private void LogOutBTN_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void InstallProductBTN_Click(object sender, EventArgs e)
        {
            Installation InstallationClass = new Installation();
            InstallationClass.Show();
            this.Hide();
        }

        private void MaintainBTN_Click(object sender, EventArgs e)
        {
            Maintenance MaintenanceClass = new Maintenance();
            MaintenanceClass.Show();
            this.Hide();
        }

        public void updateChange()
        {
            MessageBox.Show("Successfully updated Client details", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public void failedUpdate()
        {
            MessageBox.Show("Update could not execute because some textboxes do not have values, please fill in all available textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
