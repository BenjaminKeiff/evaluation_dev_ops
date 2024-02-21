using EvaluationSampleCode;
using System.ComponentModel.DataAnnotations;

namespace TestEvaluation.UnitTests
{
    [TestClass]
    public class MathOperationsTests
    {

        [TestMethod]
        [DataRow(11,5)]
        public void Substract_IfNumberOneIsInferiorAtNumberTwo_returnTrue(int numberOne, int numberTwo)
        {
            var MathOperation = new MathOperations();

            var result = MathOperation.Subtract(numberOne,numberTwo);

            Assert.IsNotNull(result);
        }
    }
}