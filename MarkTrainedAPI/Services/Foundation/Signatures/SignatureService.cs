using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Foundation.Signatures
{
    internal partial class SignatureService : ISignatureService
    {
        public async ValueTask UploadFile(string fileName, byte[] data)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"{fileName} uploaded succefully!");
            });
        }
    }
}
