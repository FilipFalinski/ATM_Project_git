using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace ATM_Project
{
    public interface IAccountRepository
    {
        Account Load(String accountId);

        void Save(Account account);
    }
}
