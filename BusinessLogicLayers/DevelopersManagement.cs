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
   public class DevelopersManagement : Products
    {
        private int DeveloperID;
        private string name;
        private string lastName;
        private int age;
        private int contact;
        private string email;
        private string speciality;
        private string description;

        public DevelopersManagement()
        {

        }

        public DevelopersManagement(int developerID, string name, string lastName, int age, int contact, string email, string speciality, string description)
        {
            DeveloperID1 = developerID;
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Contact = contact;
            this.Email = email;
            this.Speciality = speciality;
            this.Description = description;
        }

        public int DeveloperID1 { get => DeveloperID; set => DeveloperID = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public int Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string Speciality { get => speciality; set => speciality = value; }
        public string Description { get => description; set => description = value; }

        List<DevelopersManagement> developersList = new List<DevelopersManagement>();
        DBAccess DBAccessClass = new DBAccess();
        DataSet DataSet = new DataSet();

        public List<DevelopersManagement> GetDevelopers()
        {
            DataSet = DBAccessClass.GetData("Developer");
            try
            {
                foreach (DataRow item in DataSet.Tables["Developer"].Rows)
                {
                    developersList.Add(new DevelopersManagement(
                        int.Parse(item["DevID"].ToString()),
                        item["DeverloperFirstName"].ToString(),
                        item["DeverloperLastName"].ToString(),
                        int.Parse(item["Age"].ToString()),
                        int.Parse(item["Contact"].ToString()),
                        item["Email"].ToString(),
                        item["Speciality"].ToString(),
                        item["Descriptions"].ToString()
                        ));
                }
            }
            catch (Exception)
            {

                throw;
            }
            return developersList;
        }


    }
}
