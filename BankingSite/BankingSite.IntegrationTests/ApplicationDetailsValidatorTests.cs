

using BankingSite.Model;
using BankingSite.Model.DomainEntities;
using NUnit.Framework;

namespace BankingSite.IntegrationTests
{
    [TestFixture]
    public class ApplicationDetailsValidatorTests
    {

        [Test]
        public void ShouldValidateCorrectApplication() 
        {
            var sut = new ApplicationDetailsValidator( new AirlineMembershipNumberValidator());

            var a = new CreditCardApplication {

                AirlineFrequentFlyerNumber = "A1234567",
                ApplicantAgeInYears = 44, 
                ApplicantName = "Lisa"

            };

            var errors = sut.Validate(a);

            Assert.That(errors, Is.Empty);


        
        
        }


    }
}
