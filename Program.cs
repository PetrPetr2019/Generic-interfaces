using System;
using System.Collections.Generic;
using System.Linq;
using StaffSport;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region реализация экземпляра интерфейса
            //var list = new List<ISwitchable<int>>
            //{
            //    new Laptop(),
            //    new TV()
            //};
            //foreach (var result in list)
            //{
            //    result.SwitchTVOf();
            //    result.SwitchTVOn();
            //}
            #endregion
            #region ref/out
            //var a1 = "Petr";
            //var a2 = "Ponomarev";
            //Swop(ref a1, ref a2);
            //Console.WriteLine(a1 + a2);
            #endregion


            //var s1 = "Petr";
            //var s2 = "Ponomarev";
            //Swop(ref s1, ref s2);
            //Console.WriteLine(s1 + " " +  s2);
            var s1 = 5;
            var s2 = 10;
            Swop(ref s1, ref s2);
            Console.WriteLine(s1 + " " + s2);
            Console.ReadLine();
        }

        #region Обобщенный метод

        //public static void Method<T>(IEnumerable<T>collection) // Более универсальный метод
        //{

        //}
        //public static void Method<T>(List<T>collection) // Плохой метод не универсальный 
        //{

        //}
        #endregion
        #region Swop(T)
        //private static void Swop<T>(ref T a, ref T b)
        //{
        //    var temp = a;
        //    a = b;
        //    b = temp;
        //}
        #endregion

        public static void Swop<T>(ref T a1, ref T a2)
        {
            var tepm = a1;
            a1 = a2;
            a2 = tepm;

        }


    }

}
