using System.ComponentModel.DataAnnotations;

namespace OrderProcessingApp.Models {
    public class Payment {
        public int PaymentId { get; set; }        
        public string PaymentMode {get;set;}
        [Required]
        public string PaymentFor { get; set; }
    }
}
