using System;


namespace Exercise._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speed Limmit:");
            var speedlimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Speed of Car:");
            var Car = Convert.ToInt32(Console.ReadLine());

            if (Car < speedlimit)
                Console.WriteLine("OK");
            else
            {
                const int KmperDemeritpoint = 5;
                var Demeritpoints = (Car - speedlimit) / KmperDemeritpoint;
                if (Demeritpoints < 12) 
                Console.WriteLine("License Suspended");
                else 
                Console.WriteLine("License suspended "+Demeritpoints);

            }

        }
    }
}

