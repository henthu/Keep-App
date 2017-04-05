using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Goal
    {
        public Goal(string name, string description, DateTime ultimatum)
        {
            Name = name;
            Description = description;
            Ultimatum = ultimatum;
            Progress = 0;
            Status = GoalStatus.INITIATED;
            Priority = GoalPriority.MEDIUM;           
        }

        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime Ultimatum { get; set; }
        public double Progress { get; set; }
        public GoalStatus Status { get; set; }
        public GoalPriority Priority { get; set; }

        public enum GoalStatus
        {
            INITIATED,
            IN_PROGRESS,
            COMPLETED,
            DELETED
        }

        public enum GoalPriority
        {
            CRITICAL,
            HIGH,
            MEDIUM,
            LOW
        }

        public void ChangeGoalStatus( Goal.GoalStatus status)
        {
            Status = status;
        }

        public void ChangeGoalPriority(Goal.GoalPriority priority)
        {
            Priority = priority;
        }
    }
}
