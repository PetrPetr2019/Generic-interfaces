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

            var list = new List<ISwitchable<int>>
            {
                new Laptop(),
                new TV()
            };
            foreach (var result in list)
            {
                result.SwitchTVOf();
                result.SwitchTVOn();
            }
            #region ref/out
            //var a1 = "Petr";
            //var a2 = "Ponomarev";
            //Swop(ref a1, ref a2);
            //Console.WriteLine(a1 + a2);
            #endregion
            


           
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


    }

}
