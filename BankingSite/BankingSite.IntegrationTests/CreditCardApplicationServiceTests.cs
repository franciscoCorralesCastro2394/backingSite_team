using BankingSite.Model.DomainEntities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSite.IntegrationTests
{
    [TestFixture]
    public class CreditCardApplicationServiceTests
    {

        //[Test]
        //public void ShouldSubmitVAlidApplication() {

        //    var sut = new ServiceReference1.CreditCardApplicationServiceClient();

        //    var a = new CreditCardApplication { 
        //        AirlineFrequentFlyerNumber = "A1234567",
        //        ApplicantAgeInYears = 30,
        //        ApplicantName = "Jason"
        //    };


        //    var submissionResult = sut.SubmitApplication(a);

        //    Assert.That(submissionResult.ValidationErrors, Is.Empty);
        //    Assert.That(submissionResult.ReferenceNumber, Is.Not.Null);

        //    var successfulApplicationName = sut.GetSuccesfulApplicantsName(submissionResult.ReferenceNumber.Value);

        //    Assert.That(successfulApplicationName, Is.EqualTo("Jason"));

        //}
    }
}
