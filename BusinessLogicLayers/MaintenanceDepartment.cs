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
   public class MaintenanceDepartment : Client
    {
        public event change onChangingMaintenancePlan;

        private int maintenanceID;
        private string maintenanceType;
        private string maintainDescription;
        private DateTime installationDate;

        public MaintenanceDepartment()
        {

        }

        public MaintenanceDepartment(int maintenanceID, string maintenanceType, string maintainDescription, DateTime installationDate)
        {
            this.MaintenanceID = maintenanceID;
            this.MaintenanceType = maintenanceType;
            this.MaintainDescription = maintainDescription;
            this.InstallationDate = installationDate;
        }

        DBAccess DBAccessClass = new DBAccess();

        public int MaintenanceID { get => maintenanceID; set => maintenanceID = value; }
        public string MaintenanceType { get => maintenanceType; set => maintenanceType = value; }
        public string MaintainDescription { get => maintainDescription; set => maintainDescription = value; }
        public DateTime InstallationDate { get => installationDate; set => installationDate = value; }

        public List<MaintenanceDepartment> GetMaintenance()
        {

           DataSet DataSet = DBAccessClass.GetData("ConfigSettings");
            List<MaintenanceDepartment> maintenancelist = new List<MaintenanceDepartment>();
            try
            {
                foreach (DataRow item in DataSet.Tables["ConfigSettings"].Rows)
                {
                    maintenancelist.Add(new MaintenanceDepartment(
                        int.Parse(item["ConfigID"].ToString()),
                        item["ConfigurationType"].ToString(),
                        item["ConfigurationDescription"].ToString(),
                        DateTime.Parse(item["ConfigurationDate"].ToString())));
                }
            }
            catch (Exception)
            {

                throw;
            }
            return maintenancelist;
        }

    }
}
