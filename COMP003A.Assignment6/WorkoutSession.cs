using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    public class WorkoutSession
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
        
    }
}
