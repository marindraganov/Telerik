namespace _02.Students
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private int workHoursPerDay;
        private decimal weekSalary;

        public Worker(string firstName, string lastName, int workHoursPerDay, decimal weekSalary)
            : base(firstName, lastName)
        {
            this.WorkHoursPerDay = workHoursPerDay;
            this.WeekSalary = weekSalary;
        }

        public int WorkHoursPerDay 
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hm? Is this person too lazy?");
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hm? Who works for nothing?");
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }

        public decimal MoneyPerHour()
        {
            int workDays = 5;

            return this.WeekSalary / (workDays * this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} money/hour = {2:C2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
