using BankingSite.Model;
using BankingSite.Model.DomainEntities;
using BankingSite.Model.ExternalComponentGateways;
using Moq;
using Ninject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSite.IntegrationTests
{
    [TestFixture]
    public class ApplicationScoringSubsystemTest
    {
        [Test]
        public void ShouldScoreApplicationCorrectly() {

            //var realCredictCheckerGateway = new CreditCheckerGateway();
            var fakeMainframe = new Mock<IBankMainframeGateway>();
            fakeMainframe.Setup(x => x.CreateNew(It.IsAny<CreditCardApplication>())).Returns(42);

            var kernel = new StandardKernel();

            kernel.Bind<ICreditCheckerGateway>().To<CreditCheckerGateway>();
            kernel.Bind<IBankMainframeGateway>().ToConstant(fakeMainframe.Object);



            //var sut = new CreditCardApplicationScorer(realCredictCheckerGateway,fakeMainframe.Object);

            var sut = kernel.Get<CreditCardApplicationScorer>();

            var a = new CreditCardApplication {

                AirlineFrequentFlyerNumber = "A123456789",
                ApplicantAgeInYears = 44,
                ApplicantName = "Jason"
            };

            var result = sut.ScoreApplication(a);

            Assert.That(result, Is.Not.Null);



        }

    }
}
