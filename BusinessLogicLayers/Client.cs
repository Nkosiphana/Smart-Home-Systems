using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayers
{
    public delegate void change();
   public class Client
    {
        public event change changingDetails;
        

        private int ID;
        private string name;
        private string lastName;
        private int age;

        public Client()
        {

        }

        public Client(int iD, string name, string lastName, int age)
        {
            ID = iD;
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age;
            set
            {
                age = value;
                if (age != null)
                {
                    changingDetails += new change(EventHandler);
                    changingDetails.Invoke();

                }

            }            
        }

        DataSet DataSet = new DataSet();
        DBAccess DBAccessClass = new DBAccess();
        public List<Client> GetClients()
        {
         
            DataSet = DBAccessClass.GetData("Client");
            List<Client> clientlist = new List<Client>();
            try
            {
                foreach (DataRow item in DataSet.Tables["Client"].Rows)
                {
                    clientlist.Add(new Client(
                        int.Parse(item["ID"].ToString()),
                        item["FirstName"].ToString(),
                        item["LastName"].ToString(),
                        int.Parse(item["Age"].ToString())));
                }
            }
            catch (Exception)
            {

                throw;
            }
            return clientlist;
        }

        public void insertClient(string newFirstName, string newLastName, int Age, int contactInfo, string gender, string password)
        {
            string query = string.Format("INSERT INTO Client (FirstName,LastName,Age,ContactInfo,Gender,Passwords)"
                + " VALUES ('" + newFirstName + "','" + newLastName + "','" + Age + "','" + contactInfo + "','" + gender + "','" + password + "')");
            DBAccessClass.InsertData(query);
        }

        Dictionary<string, string> LoginList = new Dictionary<string, string>();

        public Dictionary<string,string> GetLoginDetails()
        {
            DataSet = DBAccessClass.GetData("Client");

            foreach (DataRow item  in DataSet.Tables["Client"].Rows)
            {
                LoginList.Add(item["FirstName"].ToString(), item["Passwords"].ToString());
            }

            return LoginList;

        }

        public void UpdateClient(int sameID, string newFirstName, string newLastName, int newAge) { 
             string query = string.Format("UPDATE Client SET FirstName = '" + newFirstName + "', LastName = '" + newLastName + "', Age = '" + newAge + "' WHERE ID = '" + sameID + "'");
            DBAccess dB = new DBAccess();
            dB.UpdateData(query);

        }

        public void EventHandler()
        {
            string message = "Happy birthday";
        }
    }
}
