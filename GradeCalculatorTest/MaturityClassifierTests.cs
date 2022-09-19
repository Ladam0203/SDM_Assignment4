using SDM_Assignment4;

namespace GradeCalculatorTest;

public static class MaturityClassifierTests
{
    private static DateOnly today = new DateOnly(2020, 1, 1);
    
    [Theory]
    [InlineData(2007, 01, 02)] //one day before 13
    [InlineData(2000, 1, 1)] //first day being 20
    public static void AgeOutsideBoundaries(int year, int month, int day)
    {
        MaturityClassifier classifier = new MaturityClassifier(today);
        DateOnly birthday = new DateOnly(year, month, day);
        
        bool isTeenager = classifier.IsTeenager(birthday);
        
        Assert.False(isTeenager);
    }
    
    [Theory]
    [InlineData(2006, 6, 12)] //last day before turning 13
    [InlineData(2003, 11, 30)] //last day before turning 20
    public static void AgeInsideBoundaries(int year, int month, int day)
    {
        MaturityClassifier classifier = new MaturityClassifier(today);
        DateOnly birthday = new DateOnly(year, month, day);
        
        bool isTeenager = classifier.IsTeenager(birthday);
        
        Assert.True(isTeenager);
    }
}