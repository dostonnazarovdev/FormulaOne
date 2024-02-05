using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    public class GP
    {  
        private List<Time> timeList = new List<Time>();
        public GP(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public  List<Driver> getGPRanking()
        {
          List<Driver> result = new List<Driver>();
            timeList.Sort();
            foreach (var time in timeList)
            {
                result.Add(time.Driver);
            }
            return result;
        }


        public static int getPosition(Driver driver)
        {
            return 0;
        }

        public void addTimeList(Time time)
        {
            timeList.Add(time);
        }
    }
}
