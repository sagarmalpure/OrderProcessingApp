using OrderProcessingApp.Models;
using OrderProcessingApp.Services.Interfaces;

namespace OrderProcessingApp.Services {

    public class GeneratePackingSlipService : IGeneratePackingSlipService {

        public void GeneratePkgSlip(Payment payment) {

            PkgSlip(payment);
        }
        private void PkgSlip(Payment payment) {

            if (payment.PaymentFor == "PhysicalProduct" || payment.PaymentFor == "Book") {

                if (payment.PaymentFor == "Book") {

                    // generate duplicate pkg slip fpr royalty department

                    GenerateDuplicatePkgSlip();
                }

                // generate Commision Payment To the Agent
                GenerateCommisionPaymentToAgent();
            }
            else if (payment.PaymentFor == "Membership" || payment.PaymentFor == "Upgrade-Membership") {

                // activate or upgrade membership
                MembershipActivateAndUpgrade(payment.PaymentFor);

                //send notification email to the owner for membership activation/upgrade
                SendEmail();

            }
            else {
                // payment made for video "Learning to Ski"

                if(payment.PaymentFor == "Learning to Ski") {

                    // add a free First Aid video to packing slip
                }
            }

            // common logic for generate packing slip for all products 
        }

        private void GenerateDuplicatePkgSlip() {
            // generate duplicate pkg slip for royalty department
        }
        private void GenerateCommisionPaymentToAgent() {
            // generate Commision Payment To the Agent
        }
        private void MembershipActivateAndUpgrade(string paymentFor) {
            if (paymentFor == "Membership") {

                // activate membership 
            }
            else {
                // upgrade membership
            }
        }
        private void SendEmail() {
            // send notification email to the owner for membership activation/upgrade
        }
    }
}
