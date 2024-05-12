using Xunit;
using tpmodul12_1302220046;

namespace tpmodul12_1302220046.nUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCariTandaBilangan_Negative()
        {
            // Arrange
            int input = -5;

            // Act
            string result = Form1.CariTandaBilangan(input);

            // Assert
            Assert.Equal("Negatif", result);
        }

        [Fact]
        public void TestCariTandaBilangan_Positive()
        {
            // Arrange
            int input = 5;

            // Act
            string result = Form1.CariTandaBilangan(input);

            // Assert
            Assert.Equal("Positif", result);
        }

        [Fact]
        public void TestCariTandaBilangan_Zero()
        {
            // Arrange
            int input = 0;

            // Act
            string result = Form1.CariTandaBilangan(input);

            // Assert
            Assert.Equal("Nol", result);
        }
    }
}
