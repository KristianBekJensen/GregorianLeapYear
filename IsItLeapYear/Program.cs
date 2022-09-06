namespace IsItLeapYear;
public class Program
{
    static void Main(String []args){
        Console.WriteLine("Is it leap year?");
        Console.WriteLine("Write a year");
        int year = Convert.ToInt32(Console.ReadLine());
        bool answer = LeapYearFinder.IsLeapYear(year);
        if (answer){
            Console.WriteLine("yay");
        }else{
            Console.WriteLine("nay");
        }
    }
}
