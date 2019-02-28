using Safester.CryptoLibrary.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PgpWeb.App.Models
{
    public class PgpCreation
    {
        public string Identity { get; set; }
        public string Passphrase { get; set; }
        public PublicKeyAlgorithm Algorithm { get; set; }
        public PublicKeyLength Length { get; set; }
    }
}
