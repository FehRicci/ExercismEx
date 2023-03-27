using Exercises.BookingUp;
using Exercises.InterestIsInteresting;
using Exercises.Pangram;
using Exercises.SqueakyClean;
using Exercises.Triangle;


internal class Program
{
    private static void Main(string[] args)
    {

        //Console.WriteLine(Identifier.Clean("my   Id"));
        //Console.WriteLine(Identifier.Clean("my\0Id"));
        //Console.WriteLine(Identifier.Clean("à-ḃç"));
        //Console.WriteLine(Identifier.Clean("1😀2😀3😀"));
        //Console.WriteLine(Identifier.Clean("MyΟβιεγτFinder"));
        //Console.WriteLine(Identifier.Clean("a-bc"));

        //Console.WriteLine(Appointment.Schedule("Thursday, July 25, 2019 13:45:00"));
        //Console.WriteLine(Appointment.Schedule("July 25, 2019 13:45:00"));
        //Console.WriteLine(Appointment.Schedule("7/25/2019 13:45:00"));
        //Console.WriteLine(Appointment.HasPassed(new DateTime(1999, 12, 31, 9, 0, 0)));
        //Console.WriteLine(Appointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 15, 0, 0)));
        //Console.WriteLine(Appointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 10, 0, 0)));
        //Console.WriteLine(Appointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 19, 0, 0)));
        //Console.WriteLine(Appointment.Description(new DateTime(2019, 03, 29, 15, 0, 0)));
        //Console.WriteLine(Appointment.AnniversaryDate());

        //Console.WriteLine(SavingsAccount.InterestRate(balance: 200.75m));
        //Console.WriteLine(SavingsAccount.Interest(balance: 200.75m));
        //Console.WriteLine(SavingsAccount.AnnualBalanceUpdate(balance: 200.75m));
        //Console.WriteLine(SavingsAccount.YearsBeforeDesiredBalance(balance: 200.75m, targetBalance: 214.88m));

        //Console.WriteLine(Pangram.checkPangram("OI"));
        //Console.WriteLine(Pangram.checkPangram("The quick brown fox jumps over the lazy dog"));

        Console.WriteLine("Equelatero :" + Triangle.IsEquilateral(5,5,5));
        Console.WriteLine("Equelatero :" + Triangle.IsEquilateral(5, 10, 5));
        Console.WriteLine("Isosceles :" + Triangle.IsIsosceles(5, 5, 5));
        Console.WriteLine("Isosceles :" + Triangle.IsIsosceles(5, 10, 5));
        Console.WriteLine("Escaleno :" + Triangle.IsScalene(5, 5, 5));
        Console.WriteLine("Escaleno :" + Triangle.IsScalene(1, 2, 3));
        Console.WriteLine("Isosceles :" + Triangle.IsIsosceles(1, 1, 3));

    }
}