using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace erp.Data
{
    public class ErpContext : IdentityDbContext<IdentityUser>
    {
        public ErpContext() : base("ErpContext")
        {

        }
    }
}
