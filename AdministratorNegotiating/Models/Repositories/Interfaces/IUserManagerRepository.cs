﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorNegotiating.Models.Repositories.Interfaces
{
    public interface IUserManagerRepository
    {
        bool Login(string name, string hashPassword);
    }
}
