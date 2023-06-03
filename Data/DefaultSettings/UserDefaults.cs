using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nexus_connect.Data.DefaultSettings
{
    public class UserDefaults
    {
        public Data.StatusType DefaultStatus => Data.StatusType.Active;
        public Data.PermissionType DefaultPermission => Data.PermissionType.Operator;
        public int DefaultTeam => 1;
    }
}