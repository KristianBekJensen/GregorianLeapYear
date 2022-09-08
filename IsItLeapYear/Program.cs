namespace IsItLeapYear;
public class Program
{
    static void Main(String []args){
        Console.WriteLine("Is it leap year?");
        Console.WriteLine("Write a year");
        bool typedYear = false;
        int year;
        bool answer = false;
        
        while(!typedYear){
            try{
                year = Convert.ToInt32(Console.ReadLine());
                answer = LeapYearFinder.IsLeapYear(year);
                if (answer){
                    Console.WriteLine("yay");
                }else{
                    Console.WriteLine("nay");
                }
                typedYear = true;
            }catch (System.FormatException){
                Console.WriteLine("You have to write a year");
            }catch (System.ArgumentException e){
                Console.WriteLine(e.Message);
            }
        }

        if (answer){
            Console.WriteLine("yay");
        }else{
            Console.WriteLine("nay");
        }
    }
}
