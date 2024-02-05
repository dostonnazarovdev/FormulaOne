using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    public class Chempionship
    {
        private List<Driver> driverList = new List<Driver>();
        private List<GP> gpList = new List<GP>();
        private List<Time> timeList = new List<Time>();


        public Driver createDriver(string name)
        {
            var exist =  getDriver(name);
            if (exist != null)
            {
                return 
                    
                    
                    
                    null;
            }
            var driver = new Driver(name);
            driverList.Add(driver);
            return driver;
        }
        public List<Driver> getDrivers()
        {
            return driverList;
        }
        public Driver getDriver(string name)
        {
            foreach (var dr in driverList)
            {
                if (dr != null && dr.Name==name)
                {
                    return dr;
                }
            }
            return null;
        }


        public GP defineGrandPrix(string name)
        {
           var gp =  getGrandPrix(name);
            if(gp!=null)
            {
                return null;
            }
            GP gps = new GP(name);
            gpList.Add(gps);
            return gps;
        }

        public GP getGrandPrix(string name)
        {
            foreach (var gp in gpList)
            {
                if(gp!=null && gp.Name.Equals(name))
                {
                    return gp;
                }
            }
            return null;
        }

        public Time setTime(GP gp, Driver r, int hours, int min, int sec, int cent)
        {
            Time time = new Time(gp,r,hours,min,sec,cent);
            timeList.Add(time);
            gp.addTimeList(time);
            return time;
        }


        public List<Driver> getChampionshipRanking()
        {
            
            return null;
        }
    }
}
