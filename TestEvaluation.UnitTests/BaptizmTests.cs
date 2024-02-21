using EvaluationSampleCode;

namespace TestEvaluation.UnitTests
{
    [TestClass]
    public class BaptizmTests
    {
        ClergyMember pope;
        ClergyMember priest;

        [TestMethod]
        public void CanBeBaptizedBy_IfIsClergyMember_ReturnTrue(Baptizm baptizm)
        {
            var member = new ClergyMember();

            Assert.IsTrue(baptizm.CanBeBaptizedBy(member));
        }
    }
}