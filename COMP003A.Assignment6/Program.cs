namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkoutSession session1 = new WorkoutSession("Cardio Session", 30, false);
            WorkoutSession session2 = new WorkoutSession("Weight Lifting", 60, true);
            WorkoutSession session3 = new WorkoutSession("Stretching", 20, true);
        }
    }
}
