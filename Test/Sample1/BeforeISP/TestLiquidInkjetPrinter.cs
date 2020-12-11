using Xunit;
using PracticeInterfaceSegregationPrinciple.Sample1.BeforeISP;

namespace Test.Sample1.BeforeISP
{
    public class TestLiquidInkjetPrinter
    {
        public class FaxMethod
        {
            [Fact]
            public void Fax_ThrowException()
            {
                LiquidInkjetPrinter printer = new LiquidInkjetPrinter();
                string content = "I am a test.";

                Assert.Throws<System.NotImplementedException>(() => printer.Fax(content));
            }
        }
    }
}
