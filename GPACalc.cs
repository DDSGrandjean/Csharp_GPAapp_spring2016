using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAapp
{
    class GPACalc
    {
        int creditHours;
        string grade;
        double totalHours;
        double totalPoints;
        double gpa;

        public GPACalc(){}

        public int CreditHours
        {
            set
            {
                creditHours = value;
                totalHours += creditHours;
            }
        }

        public string Grade
        {
            set
            {
                grade = value.ToUpper();
                totalPoints += GetMultiplier();
            }
        }

        private int GetMultiplier()
        {
            int multiplier;
            
            switch (grade)
            {
                case "A": multiplier = 4; break;
                case "B": multiplier = 3; break;
                case "C": multiplier = 2; break;
                case "D": multiplier = 1; break;
                default : multiplier = 0; break;
            }
            return creditHours * multiplier;
        }

        private void CalculateGPA()
        {
            gpa = totalPoints / totalHours;
        }

        public override string ToString()
        {
            CalculateGPA();

            return "Total Hours: "   + totalHours +
                   "\nTotal Point: " + totalPoints +
                   "\nGPA: "         + gpa.ToString("f1");

        }
    }
}
