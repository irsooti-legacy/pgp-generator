using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PgpWeb.App.Models;
using Safester.CryptoLibrary.Api;

namespace PgpWeb.App.Pages
{
    public class IndexModel : PageModel
    {

        public void OnGet()
        {

        }
        [HttpPost]
        public void OnPost(PgpCreation model)
        {
            try
            {
                var generator = new PgpKeyPairGenerator(model.Identity, model.Passphrase.ToCharArray(), model.Algorithm, model.Length);
                var generatedKey = generator.Generate();

                ViewData["Identity"] = model.Identity;
                ViewData["Passphrase"] = model.Passphrase;
                ViewData["Algorithm"] = model.Algorithm;
                ViewData["Length"] = model.Length;

                ViewData["PrivateKey"] = generatedKey.PrivateKeyRing;
                ViewData["PublicKey"] = generatedKey.PublicKeyRing;
            }

            catch (Exception err)
            {
                ModelState.AddModelError("generic", err.Message);
            }
        }
    }
}
