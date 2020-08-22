using OrderProcessingApp.Models;

namespace OrderProcessingApp.Services.Interfaces {
    public interface IGeneratePackingSlipService
    {
        void GeneratePkgSlip(Payment payment);       
    }
}
