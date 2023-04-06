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