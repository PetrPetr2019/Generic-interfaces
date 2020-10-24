using System;
using System.Collections.Generic;
using System.Text;

namespace StaffSport
{
    static class staticClass
    {
        public static int Age { get; set; }
        public static string Name { get; set; }

         static staticClass()
         {
             Age = 44;
             Name = "Jon";
         }

         public  static  void Show()
        {
            Console.WriteLine($"Возраст:{Age}:Имя:{Name}");
        }
    }
}
