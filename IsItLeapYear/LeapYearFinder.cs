namespace IsItLeapYear;

public class LeapYearFinder
{
    public static bool IsLeapYear(int year){
        if (year < 1582){
            throw new ArgumentException("Year Must Be greater than 1582");
        }
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}