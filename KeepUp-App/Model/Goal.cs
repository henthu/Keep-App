using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Goal
    {
        public String Name { get; set; }
        public enum Priority
        {
            CRITICAL,
            HIGH,
            MEDIUM,
            LOW
        }

        public DateTime Ultimatum { get; set; }

    }
}
