using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    public class Time
    {


        public Time(GP gp, Driver r, int hours, int min, int sec, int cent)
        {
            Gp = gp;
            Driver = r;
            Hours = hours;
            Minutes = min;
            Seconds = sec;
            Ms = cent;
        }

        public GP Gp { get; set; }
        public Driver Driver { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int Ms { get; set; }







        public override string ToString()
        {
            return Hours + ":" + Minutes + ":" + Seconds + "." + Ms;
        }

     
      

    }
}
