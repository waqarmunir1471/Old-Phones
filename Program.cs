using Microsoft.Win32.SafeHandles;
using System;
using Old_Phones.Models;
namespace Old_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######################");
            Galaxy s8=new Galaxy("Samsung Galaxy S8",86,"Verizon","Tinggggggggggggggggggggg");
            s8.DisplayInfo();
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());

            Console.WriteLine("######################");
            Console.WriteLine("######################");
            Nokia N95=new Nokia("Nokia N95",43,"T-Mobile","Nokiaaaaaaaaaa");
            N95.DisplayInfo();
            Console.WriteLine(N95.Ring());
            Console.WriteLine(N95.Unlock());
            Console.WriteLine("######################");


        }
    }
}
