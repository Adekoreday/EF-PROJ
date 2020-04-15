using System;
namespace SamuriApp.Domain
{
    public class Quote
    {
        public Quote(){ }

        public int Id { get; set; }
        public String Text { get; set; }
        public Samuri Samuri { get; set; }
        public int SamuriId { get; set; }
        
    }
}
