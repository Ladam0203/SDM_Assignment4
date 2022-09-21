using System.Runtime.CompilerServices;

namespace SDM_Assignment4;

public class MaturityClassifier
{
    private DateOnly? Today { get; set; }

    public MaturityClassifier(DateOnly today)
    {
        Today = today;
    }

    public MaturityClassifier()
    {
        Today = null;
    }
    
    public bool IsTeenager(DateOnly birthday)
    {
        DateOnly today = Today ?? DateOnly.FromDateTime(DateTime.Now);
        return birthday.AddYears(13) <= today && today <= birthday.AddYears(19).AddMonths(11).AddDays(30);
    }
}