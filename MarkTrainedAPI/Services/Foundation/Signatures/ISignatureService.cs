using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Foundation.Signatures
{
    internal interface ISignatureService
    {
        ValueTask UploadFile(string fileName, byte[] data);
    }
}
