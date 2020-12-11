using Xunit;
using PracticeInterfaceSegregationPrinciple.Sample1.BeforeISP;

namespace Test.Sample1.BeforeISP
{
    public class TestHPLaserJetPrinter
    {
        public class FaxMethod
        {
            [Fact]
            public void Fax_Calculated()
            {
                HPLaserJetPrinter printer = new HPLaserJetPrinter();
                string content = "I am a test.";
                string expected = "HPLaserJetPrinter Fax : " + content;

                Assert.Equal(expected, printer.Fax(content));
            }
        }
    }
}
