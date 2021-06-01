using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_v1
{
    public class Schedule
    {
        public readonly int id;
        private List<string> workDays;
        private string[] arr = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public string StartTime { get; protected set; }
        public string EndTime { get; protected set; }
        public List<string> WorkDays {
            get
            {
                return workDays;
            }
            protected set
            {
                for (int i = 0; i < value.Count; i++)
                {
                    for (int j = 1; j < value.Count - 1; j++)
                    {
                        if (Array.IndexOf(arr, value[i]) > Array.IndexOf(arr, value[j]))
                        {
                            string temp = value[i];
                            value[i] = value[j];
                            value[j] = temp;
                        }
                    }
                }
                workDays = value;
            }
        }

        public Schedule(
            int id,
            string startTime,
            string endTime,
            List<string> workDays)
        {
            this.id = id;
            StartTime = startTime;
            EndTime = endTime;
            WorkDays = workDays;
        }

        public void ChangeSchedule(Schedule newSchedule)
        {
            StartTime = newSchedule.StartTime;
            EndTime = newSchedule.EndTime;
            WorkDays = newSchedule.WorkDays;
        }

        public void DisplayInfo() => Console.WriteLine("Schedule Info:\n" + ToString());

        public override string ToString() => $"StartTime: {StartTime}, EndTime: {EndTime}" +
            $"WorkDays: {string.Join(", ", WorkDays)}";

        public static Schedule operator +(Schedule c1, string day)
        {
            if (c1.WorkDays.Contains(day))
                return c1;
            c1.WorkDays.Add(day);
            return c1;
        }

        public static Schedule operator -(Schedule c1, string day)
        {
            if (c1.WorkDays.Contains(day))
                c1.WorkDays.Remove(day);
            return c1;
        }
    }
}
