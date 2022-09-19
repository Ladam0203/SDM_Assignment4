using SDM_Assignment4;

namespace GradeCalculatorTest;

public class UnitTest1
{
    [Theory]
    [InlineData(-1)]
    [InlineData(101)]
    public void TestInvalidNumbersInRange(int percentage)
    {
        //Assert + Act
        Assert.Throws<ArgumentOutOfRangeException>(() => GradeCalculator.ToGrade(percentage));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(3)]
    [InlineData(7)]
    public void TestGradeNegativeThree(int percentage)
    {
        //Arrange
        int expectedResult = -3;
        
        //Act
        int actualResult = GradeCalculator.ToGrade(percentage);
        
        //Assert
        Assert.Equal(expectedResult, actualResult);
    }
    
    [Theory]
    [InlineData(8)]
    [InlineData(20)]
    [InlineData(33)]
    public void TestGrade00(int percentage)
    {
        //Arrange
        int expectedResult = 0;
        
        //Act
        int actualResult = GradeCalculator.ToGrade(percentage);
        
        //Assert
        Assert.Equal(expectedResult, actualResult);
    }
    
    [Theory]
    [InlineData(34)]
    [InlineData(37)]
    [InlineData(41)]
    public void TestGrade02(int percentage)
    {
        //Arrange
        int expectedResult = 2;
        
        //Act
        int actualResult = GradeCalculator.ToGrade(percentage);
        
        //Assert
        Assert.Equal(expectedResult, actualResult);
    }
    
    [Theory]
    [InlineData(42)]
    [InlineData(50)]
    [InlineData(57)]
    public void TestGrade4(int percentage)
    {
        //Arrange
        int expectedResult = 4;
        
        //Act
        int actualResult = GradeCalculator.ToGrade(percentage);
        
        //Assert
        Assert.Equal(expectedResult, actualResult);
    }
    
    [Theory]
    [InlineData(58)]
    [InlineData(68)]
    [InlineData(77)]
    public void TestGrade7(int percentage)
    {
        //Arrange
        int expectedResult = 7;
        
        //Act
        int actualResult = GradeCalculator.ToGrade(percentage);
        
        //Assert
        Assert.Equal(expectedResult, actualResult);
    }
    
    [Theory]
    [InlineData(78)]
    [InlineData(83)]
    [InlineData(89)]
    public void TestGrade10(int percentage)
    {
        //Arrange
        int expectedResult = 10;
        
        //Act
        int actualResult = GradeCalculator.ToGrade(percentage);
        
        //Assert
        Assert.Equal(expectedResult, actualResult);
    }
    
    [Theory]
    [InlineData(90)]
    [InlineData(95)]
    [InlineData(100)]
    public void TestGrade12(int percentage)
    {
        //Arrange
        int expectedResult = 12;
        
        //Act
        int actualResult = GradeCalculator.ToGrade(percentage);
        
        //Assert
        Assert.Equal(expectedResult, actualResult);
    }
}