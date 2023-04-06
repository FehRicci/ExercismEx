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
        var array = new[] { 1, 3, 4, 6, 8, 9, 11 };
        var value = 11;
        Console.WriteLine(BinarySearch.Find(array, value));
    }
}