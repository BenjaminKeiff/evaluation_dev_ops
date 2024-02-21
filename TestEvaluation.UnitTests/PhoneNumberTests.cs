using EvaluationSampleCode;
using System.ComponentModel.DataAnnotations;

namespace TestEvaluation.UnitTests
{
    [TestClass]
    public class PhoneNumberTest
    {

        [TestMethod]
        public void Parse_WithTenNumber_ReturnString()
        {
            var number = PhoneNumber.Parse("0123456789");

            Assert.IsNotNull(number);
        }
    }
}