using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{ 
    public class WorkoutSession // This class describes a workout session with the basic details and actions.
    {
        public string Name;
        public int Time;
        public bool Completed;

        public WorkoutSession(string name, int time, bool completed)
        {
            Name = name;
            Time = time;
            Completed = completed;
        }
        public void DisplayInfo() // This method just displays the current workout information.
        {
            Console.WriteLine($"Workout: {Name}, Time: {Time} minutes, Completed: {Completed}");
        }
        public void IfCompleted() // This method flips whether the workout is complete.
        {
            Completed = !Completed;
        }
    }
}
