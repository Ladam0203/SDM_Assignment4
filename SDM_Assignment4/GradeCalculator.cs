namespace SDM_Assignment4;

public static class GradeCalculator
{
    public static int ToGrade(int percentage)
    {
        if (!(0 <= percentage && percentage <= 100))
        {
            throw new ArgumentOutOfRangeException();
        }
        
        Dictionary<int, int> grades = new Dictionary<int, int>();
        grades.Add(12, 90);
        grades.Add(10, 78);
        grades.Add(7, 58);
        grades.Add(4, 42);
        grades.Add(2, 34);
        grades.Add(0, 8);
        grades.Add(-3, 0);
        //grade + lower boundary in descending order
        foreach (KeyValuePair<int,int> grade in grades)
        {
            if (grade.Value < percentage)
            {
                return grade.Key;
            }
        }
        
        throw new ArgumentOutOfRangeException();
    }
}