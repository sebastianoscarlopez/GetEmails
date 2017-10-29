using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmails
{
    class UrlDTO
    {
        public string url;
        public int idxColumn;
        public int idxRow;
        public List<string> emails = new List<string>();
    }
}
