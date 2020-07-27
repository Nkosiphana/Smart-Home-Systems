using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayers
{
    class InstallationDepartment : Client
    {
        public event change onChangingInstallation;

        private int installationID;
        private string installationType;
        private string installationDescription;
        

    }
}
