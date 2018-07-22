using Option02.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option02.Infrastructure
{
    public class ApplicantContext: DbContext
    {
        public ApplicantContext()
            :base ("name=AppConnectionString")
        {

        }

        public DbSet<ApplicantAddress> Addresses { get; set; }
    }
}
