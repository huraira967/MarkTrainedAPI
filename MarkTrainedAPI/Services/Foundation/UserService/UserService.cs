using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Foundation.UserService
{
    internal partial class UserService : IUserService
    {
        public string GetUesrSignature(int staffId)
        {
            return "signature_base64";
        }
    }
}
