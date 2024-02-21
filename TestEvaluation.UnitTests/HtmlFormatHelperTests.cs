using EvaluationSampleCode;

namespace TestEvaluation.UnitTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        [TestMethod]
        public void GetStrongFormat_IfIsStrong_ReturnTrue(HtmlFormatHelper htmlFormatHelper)
        {
            var html = htmlFormatHelper.GetStrongFormat("bcsdbcvjsd");

            Assert.IsNotNull(html);
        }
    }
}