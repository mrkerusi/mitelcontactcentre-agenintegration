using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentIntegrationTest
{
    public class UserInfo
    {
        public bool ChatReadyStatus {get; set;}

        public bool EmailReadyStatus { get; set; }

        public string ExtensionNumber { get; set; } 

        public int LoggedOn { get; set; }

        public string LoginID { get; set; }

        public int OASID { get; set; }

        public string OASServerName { get; set; }

        public bool OPenMediaReadyStatus { get; set; }

        public int RecordID { get; set; }

        public string UserName { get; set; }
    }
}
