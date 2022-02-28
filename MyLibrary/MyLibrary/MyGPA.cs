using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public static class MyGPA
    {
        /// <summary>
        /// Calculate grade form score
        /// </summary>
        /// <param name="score">student score</param>
        /// <returns>Grade form score</returns>
        /// 
        public static string calculateGrade(double score)
        {
            
            if (score >= 50)
            {
                return "S";
            }
            else
            {
                return "F";
            }
            
            //return score >= 50 ? "s" : "F"; //เป็นการเขียนคำสั่งแบบสั้น

            /*
            return score >= 3.5 ? "s" : "B+";
            return score >= 3 ? "s" : "B";
            return score >= 2.5 ? "s" : "C+";
            return score >= 2 ? "s" : "C";
            return score >= 1.5 ? "s" : "D+";
            return score >= 1 ? "s" : "D";
            return score >= 0 ? "s" : "F";
            */

            /*
            else
            {
                return score >= 0 ? "s" : "F";
            }
            */

        }
    }
}
