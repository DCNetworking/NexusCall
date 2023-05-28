using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nexus_connect.DbContext
{
    public class NexusConnectSeeder
    {
        readonly NexusConnectContext _ctx;
        public NexusConnectSeeder(NexusConnectContext ctx)
        {
            _ctx = ctx;
        }
        public void Seed()
        {
            _ctx.Database.EnsureCreated();
        }
    }
}