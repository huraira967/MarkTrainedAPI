﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Foundation.UserService
{
    internal interface IUserService
    {
        string GetUesrSignature(int staffId);
    }
}
