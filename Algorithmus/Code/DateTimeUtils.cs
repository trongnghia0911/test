using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
namespace Algorithmus
{
    public struct SystemTime
    {
        public ushort Year;
        public ushort Month;
        public ushort DayOfWeek;
        public ushort Day;
        public ushort Hour;
        public ushort Minute;
        public ushort Second;
        public ushort Millisecond;
    };
    public class DateTimeUtils
    {
        [DllImport("kernel32.dll")]
        private extern static void GetSystemTime(ref SystemTime lpSystemTime);
        [DllImport("kernel32.dll")]
        private extern static uint SetSystemTime(ref SystemTime lpSystemTime);
        //---------------------------------------------------------------------------
        public static void SetDateTime(DateTime mDateTime)
        {
            try
            {
                SystemTime systime = new SystemTime();
                systime.Year = (ushort)mDateTime.Year;
                systime.Month = (ushort)mDateTime.Month;
                systime.DayOfWeek = (ushort)mDateTime.DayOfWeek;
                systime.Day = (ushort)mDateTime.Day;
                systime.Hour = (ushort)mDateTime.Hour;
                systime.Minute = (ushort)mDateTime.Minute;
                systime.Second = (ushort)mDateTime.Second;
                systime.Millisecond = (ushort)mDateTime.Millisecond;
                SetSystemTime(ref systime);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
    }
}
