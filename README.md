# Summary

Provides examples for unit testing C# applications, including mocking

Additional references and resources for mocking can be found at: https://github.com/Moq/moq4/wiki/Quickstart

## Test Design 

* Unit tests should always be integrated as a second project within a solution. The projects can then be connected via a reference. This prevents the test libraries from being built into the production assembly. 
* Each namespace should have a corresponding namespace within the test project.
* Each class should have an associated unit test file.
* Tests should have full code coverage, as well as providing forethought into possible edge cases.
* For a method to be mockable, it must be virtual so that it can be overridden.
* In order to make our code more testable, we should use dependency injection. Classes should never directly reference one another without being passed in as a parameter. Classes should be created externally and passed in.

## Examples

* Test1 provides an example of testing a function that calls something external to its class. It accomplishes this by mocking the external object and verifying calls/results.

```code
    [Fact]
    public void Test1()
    {
        var mock = new Mock<Class2>();
        mock.Setup(foo => foo.adder(5)).Returns(6);
        var result = Program.call_adder(mock.Object);

        mock.Verify(classLib => classLib.adder(5), Times.Once());
        Assert.Equal<int>(6, result);
    }
```

* Test2 is a similar example, but the called function provides its output via a parameter.

```code
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
```