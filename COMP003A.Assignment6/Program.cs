namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args) //This program manages workout sessions using the WorkoutSession.cs class and menu loop
        {
            WorkoutSession session1 = new WorkoutSession("Cardio Session", 30, false);
            WorkoutSession session2 = new WorkoutSession("Weight Lifting", 60, true);
            WorkoutSession session3 = new WorkoutSession("Stretching", 20, true);

            bool working = true;
            while (working)
            {
                Console.WriteLine("\n1. Display All Sessions");
                Console.WriteLine("2. Update One Session");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Choice: ");
                string choices = Console.ReadLine();

                switch (choices)
                {
                    case "1":
                        Console.WriteLine();
                        session1.DisplayInfo();
                        session2.DisplayInfo();
                        session3.DisplayInfo();
                        break;
                    case "2":
                        Console.Write("\nPlease Select session to update (1-3): ");
                        string updatedChoice = Console.ReadLine();
                        switch (updatedChoice)
                        {
                            case "1":
                                session1.IfCompleted();
                                Console.WriteLine("Updated session 1.");
                                break;
                            case "2":
                                session2.IfCompleted();
                                Console.WriteLine("Updated session 2.");
                                break;
                            case "3":
                                session3.IfCompleted();
                                Console.WriteLine("Updated session 3.");
                                break;
                        }
                        break;
                    case "3":
                        working = false;
                        Console.WriteLine("\nProgram Ended");
                        break;
                }
            }
        }
    }
}
