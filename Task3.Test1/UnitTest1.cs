using System;
using System.Diagnostics;
using Xunit;
using Assert = Xunit.Assert;

namespace Task3.Test1;



public class EuclideanGcdTests
{
    [Fact]
    public void Calculate_TwoNumbers_CorrectGcd()
    {
        int result = EuclideanGcd.Calculate(30, 21);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Calculate_TwoNumbers_WithElapsed_CorrectGcdAndElapsed()
    {
        EuclideanGcd.Calculate(30, 21, out TimeSpan elapsed);
        Assert.True(elapsed > TimeSpan.Zero);
    }

    [Fact]
    public void Calculate_ThreeNumbers_CorrectGcdAndElapsed()
    {
        int result = EuclideanGcd.Calculate(30, 21, 15, out TimeSpan elapsed);
        Assert.Equal(3, result);
        Assert.True(elapsed > TimeSpan.Zero);
    }

    [Fact]
    public void Calculate_VarArgsNumbers_CorrectGcd()
    {
        int result = EuclideanGcd.Calculate(30, 21, 15, 9);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Calculate_VarArgsNumbers_WithElapsed_CorrectGcdAndElapsed()
    {
        EuclideanGcd.Calculate(out TimeSpan elapsed, 30, 21, 15, 9);
        Assert.True(elapsed > TimeSpan.Zero);
    }
}

