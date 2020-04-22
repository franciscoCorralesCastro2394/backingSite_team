using BankingSite.Model.ExternalComponentGateways;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSite.IntegrationTests
{
    [TestFixture]
    public class CreditCheckerGatewayTests
    {
        [Test]
        public void ShouldCreditCheckGoodPerson() {

            var sut = new CreditCheckerGateway();

            var isGoodCredit = sut.HasGoodCreditHistory("Jason");

            Assert.That(isGoodCredit, Is.True);

        }

        [Test]
        public void ShouldCreditCheckBadPerson()
        {

            var sut = new CreditCheckerGateway();

            var isGoodCredit = sut.HasGoodCreditHistory("Chico");

            Assert.That(isGoodCredit, Is.False);

        }
    }
}
