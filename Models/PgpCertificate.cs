using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PgpWeb.App.Models
{
    public class PgpCertificate
    {
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
    }
}
