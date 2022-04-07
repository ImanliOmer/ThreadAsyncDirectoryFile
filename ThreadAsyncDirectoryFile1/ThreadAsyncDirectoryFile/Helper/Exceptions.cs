using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadAsyncDirectoryFile.Helper
{
    internal class Exceptions
    {
        public void NotFoundException(int? Nfound)
        {
            if (Nfound == null)
            {
                throw new Exception("Not Found");
            }
        }
    }
}
