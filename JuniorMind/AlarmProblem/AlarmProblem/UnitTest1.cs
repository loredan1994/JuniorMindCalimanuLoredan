using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlarmProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var alarmSet = new Alarm[] { new Alarm(Days.Monday | Days.Friday, 1, 0), new Alarm(Days.Saturday | Days.Sunday, 9, 0) };
            Assert.AreEqual(true, checkAlarm(alarmSet, Days.Sunday, 9, 0));
            Assert.AreEqual(true, checkAlarm(alarmSet, Days.Friday, 1, 0));
            Assert.AreEqual(false, checkAlarm(alarmSet, Days.Thursday, 11, 0));
            Assert.AreEqual(false, checkAlarm(alarmSet, Days.Friday, 12, 0));
        }
    
       public struct Alarm
        {
            public Days day;
            public int hour;
            public int minutes;
            public Alarm(Days day, int hour, int minute)
            {
                this.day = day;
                this.hour = hour;
                this.minutes = minute;
            }

        }
        public enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64,

        }
        public bool checkAlarm( Alarm[] alarm , Days day, int hour , int minute)
        {
            for(int i = 0; i< alarm.Length; i++)
            {
                if (((alarm[i].day & day) != 0) && (alarm[i].hour == hour) && (alarm[i].minutes == minute))
                    return true;
            }
            return false;
        }
    }
}
