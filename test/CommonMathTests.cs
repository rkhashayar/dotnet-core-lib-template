using Xunit;
using dotnet_core_lib_template;

namespace dotnet_core_lib_template_tests;

public class CommonMathTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(3, CommonMath.Add(1, 2));
    }
}