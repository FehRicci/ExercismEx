using Exercises.BinarySearch;
using Exercises.Darts;
using Exercises.Leap;
using Exercises.ProteinTranslation;
using Exercises.BookingUp;
using Exercises.InterestIsInteresting;
using Exercises.Isogram;
using Exercises.Pangram;
using Exercises.ReverseString;
using Exercises.SqueakyClean;
using Exercises.Triangle;
using Exercises.NeedForSpeed;

internal class Program
{
    private static void Main(string[] args)
    {

<<<<<<< HEAD
        //Console.WriteLine(Identifier.Clean("my   Id"));
        //Console.WriteLine(Identifier.Clean("my\0Id"));
        //Console.WriteLine(Identifier.Clean("à-?ç"));
        //Console.WriteLine(Identifier.Clean("1??2??3??"));
        //Console.WriteLine(Identifier.Clean("My??????Finder"));
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

        //Console.WriteLine("Equelatero :" + Triangle.IsEquilateral(5,5,5));
        //Console.WriteLine("Equelatero :" + Triangle.IsEquilateral(5, 10, 5));
        //Console.WriteLine("Isosceles :" + Triangle.IsIsosceles(5, 5, 5));
        //Console.WriteLine("Isosceles :" + Triangle.IsIsosceles(5, 10, 5));
        //Console.WriteLine("Escaleno :" + Triangle.IsScalene(5, 5, 5));
        //Console.WriteLine("Escaleno :" + Triangle.IsScalene(1, 2, 3));
        //Console.WriteLine("Isosceles :" + Triangle.IsIsosceles(1, 1, 3));

        //Console.WriteLine(ReverseString.Reverse("Fernanda"));

        //Console.WriteLine(Isogram.IsIsogram("Fernanda"));
        //Console.WriteLine(Isogram.IsIsogram("lumberjacks"));
        //Console.WriteLine(Isogram.IsIsogram("background"));
        //Console.WriteLine(Isogram.IsIsogram("Alphabet"));

        //Console.WriteLine(ProteinTranslation.Proteins("AUGUUUUCU"));

        //Console.WriteLine(Leap.IsLeapYear(1997));
        //Console.WriteLine(Leap.IsLeapYear(1996));
        //Console.WriteLine(Leap.IsLeapYear(1900));
        //Console.WriteLine(Leap.IsLeapYear(2000));

        //Console.WriteLine(Darts.Score(-9, 9));
        //Console.WriteLine(Darts.Score(-0.1, -0.1));
        //Console.WriteLine(Darts.Score(-3.5, 3.5));

=======
>>>>>>> 41feec4 (Codigo refatorado seguindo feedback)
        int speed = 100;
        int batteryDrain = 60;
        var car = new RemoteControlCar(speed, batteryDrain);
        int distance = 16;
        var race = new RaceTrack(distance);
        car.Drive();
        car.Drive();
        Console.WriteLine(car.BatteryDrained());
        Console.WriteLine(car.DistanceDriven());
        Console.WriteLine(race.TryFinishTrack(car));


    }
}