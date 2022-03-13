using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabanovaLab3_WPF
{
    public class Time
    {
        public double Min { get; set; } = 0;
        public double Sec { get; set; } = 0;

        public Time(double x1, double y1)
        {
            Min = x1;
            Sec = y1;
        }

        public double Total()
        {
            return Min * 60 + Sec;
        }
        public string Print()
        {
            return $"Минуты: {Min}, Секунды: {Sec},\n" +
                   $"Общее количество секунд: {Total()} ";
        }
    }
}
