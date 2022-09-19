namespace SDM_Assignment4;

public static class GradeCalculator
{
    public static int ToGrade(int percentage)
    {
        if (!(0 <= percentage && percentage <= 100))
        {
            throw new ArgumentOutOfRangeException();
        }
        
        //In descending order
        Dictionary<int, int> grades = new Dictionary<int, int>();
        grades.Add(12, 90);
        grades.Add(10, 78);
        grades.Add(7, 58);
        grades.Add(4, 42);
        grades.Add(2, 34);
        grades.Add(0, 8);
        grades.Add(-3, 0);
        
        //Maybe sort by key first to ensure descending order
        foreach (var grade in grades)
        {
            //lower boundary = 90, percentage 92   => 12
            if (grade.Value <= percentage)
            {
                return grade.Key;
            }
        }
        
        //"Not all code returns a value", so...
        throw new ArgumentOutOfRangeException();
    }
}