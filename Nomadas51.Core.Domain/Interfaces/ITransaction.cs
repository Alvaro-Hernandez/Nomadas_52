﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomadas51.Core.Domain.Interfaces
{
    public interface ITransaction
    {
        void saveAllChanges();
    }
}
