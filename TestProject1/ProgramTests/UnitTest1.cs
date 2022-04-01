using Xunit;
using Examples;
using Moq;

namespace ExampleTests
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            var mock = new Mock<Class2>();
            mock.Setup(foo => foo.adder(5)).Returns(6);
            var result = Program.call_adder(mock.Object);

            mock.Verify(classLib => classLib.adder(5), Times.Once());
            Assert.Equal<int>(6, result);
        }
    
        [Fact]
        public void Test2() 
        {
            var mock = new Mock<Class2>();
            int x = 5;
            mock.Setup(foo => foo.param_out(out x));
            var result = Program.call_param_out(mock.Object);

            mock.Verify(classLib => classLib.param_out(out x), Times.Once());
            Assert.Equal<int>(5, result);
        }

    }
}