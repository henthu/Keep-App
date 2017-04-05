using System;
using System.Collections.Generic;
using static Model.Goal;

namespace Model
{
    public class Person
    {
        #region constructors
        public Person()
        {
            Goals = new List<Goal>();
        }

        public Person(string firstName, string lastName):this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName,List<Goal> goals):this(firstName,lastName)
        {
            Goals = goals;
        }
        #endregion
        #region properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Goal> Goals { get; set; }
        #endregion


        public void AddGoal(Goal goal)
        {
            Goals.Add(goal);
        }

        public void DeleteGoal(Goal goal)
        {
            if (Goals.Contains(goal))
            {
                Goals.Remove(goal);
                goal.Status = GoalStatus.DELETED;
            }
        }
    }
}
