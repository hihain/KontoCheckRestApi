using KontoCheckRestApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KontoCheckRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KontoCheckController : ControllerBase
    {
        private readonly ILogger<KontoCheckController> _logger;

        public KontoCheckController(ILogger<KontoCheckController> logger)
        {
            _logger = logger;
        }

        [HttpGet("iban/{iban}")]
        public BankKonto GetFromIban([FromRoute] string iban)
        {
            var retIbancheck = KontoCheckLibraryImport.iban_check(iban, out var retkontocheck);
            if (retkontocheck == -40 || retIbancheck == -142) // Note: should only occurr once kto_check_free() is used
            {
                KontoCheckLibraryImport.kto_check_init();
                retIbancheck = KontoCheckLibraryImport.iban_check(iban, out retkontocheck);
            } 
            if (retIbancheck < 1)
            {
                return new BankKonto()
                {
                    Hinweis = KontoCheckLibraryImport.retval2txt(retkontocheck)
                };
            }

            var bic = KontoCheckLibraryImport.iban2bic(iban, out var blz, out var kto, out var retval);            

            return new BankKonto()
            {
                Iban = KontoCheckLibraryImport.iban_gen(blz, kto), //Note: formatting reasons
                Bic = bic,
                Kontonummer = kto,
                Bankleitzahl = blz,
                Hinweis = KontoCheckLibraryImport.retval2txt(retval)
            };
        }

        [HttpGet("iban/blz/{blz}/kto/{kto}")]
        public BankKonto GetFromBlzKto([FromRoute] string blz, [FromRoute] string kto)
        {
            var iban = KontoCheckLibraryImport.iban_gen(blz, kto, out var retval);

            if (retval == -139) // would expect retval == -40 or -142 if konto_check is not initialized
            {
                KontoCheckLibraryImport.kto_check_init(); // Note: should only occurr once kto_check_free() is used
                iban = KontoCheckLibraryImport.iban_gen(blz, kto, out retval);
            }
            if (retval < 1)
            {
                return new BankKonto()
                {
                    Hinweis = KontoCheckLibraryImport.retval2txt(retval)
                };
            }

            return new BankKonto()
            {
                Iban = iban,
                Bic = KontoCheckLibraryImport.iban2bic(iban),
                Kontonummer = kto,
                Bankleitzahl = blz,
                Hinweis = KontoCheckLibraryImport.retval2txt(retval)
            };
        }
    }
}
