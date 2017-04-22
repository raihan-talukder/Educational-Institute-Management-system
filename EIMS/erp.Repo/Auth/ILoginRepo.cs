using erp.Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using erp.Entities.Credential;

namespace erp.Repo.Auth
{
    public interface ILoginRepo : IDisposable
    {
        Result<UserMaster> Login(string userName, string password);
    }
}
