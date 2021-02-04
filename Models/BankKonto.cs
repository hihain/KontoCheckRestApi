namespace KontoCheckRestApi.Models
{
    public class BankKonto
    {
        public string Kontonummer { get; set; }
        public string Bankleitzahl { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
        public string Hinweis { get; set; }
    }
}
