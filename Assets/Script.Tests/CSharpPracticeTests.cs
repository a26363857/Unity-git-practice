using System.Security.Cryptography;
using Microsoft.CSharp;
using NUnit.Framework;

public class CSharpPracticeTests
{
    [Test(Description = "兩數字的相加")]
    [TestCase(2, 2, 4)]
    [TestCase(3, 3, 6)]
    [TestCase(10, 10, 20)]
    [TestCase(-10, 20, 10, Description = "負數與正數的相加")]
    public void Add_Two_number(int a, int b, int expected)
    {
        //Arrange
        CsharpPractice csharpPractice = new CsharpPractice();
        //Act
        int result = csharpPractice.Add(a, b);
        //Assert
        Assert.AreEqual(expected, actual:result );
    }
    
    
}