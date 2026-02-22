namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkoutSession session1 = new WorkoutSession("Cardio Session", 30, false);
            WorkoutSession session2 = new WorkoutSession("Weight Lifting", 60, true);
            WorkoutSession session3 = new WorkoutSession("Stretching", 20, true);

            bool working = true;
            while (working)
            {
                Console.WriteLine("1. Display All Sessions");
                Console.WriteLine("2. Update One Session");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Choice: ");

            }
        }
    }
}
