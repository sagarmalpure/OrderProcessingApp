using Microsoft.AspNetCore.Mvc;
using OrderProcessingApp.Models;
using OrderProcessingApp.Services.Interfaces;

namespace OrderProcessingApp.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class GeneratePackingSlipController : ControllerBase {

        private readonly IGeneratePackingSlipService _generatePackingSlipService;
        public GeneratePackingSlipController(IGeneratePackingSlipService generatePackingSlipService) {

            _generatePackingSlipService = generatePackingSlipService;
        }

        [HttpPost("generate/Packingslip")]
        public void GeneratePackingSlip([FromBody] Payment payment) {
            _generatePackingSlipService.GeneratePkgSlip(payment);
        }
    }
}
