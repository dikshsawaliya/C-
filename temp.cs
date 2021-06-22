using System;

namespace C_
{
    class temp
    {
        public  void temperature ()
        {
                Console.Write("Enter Farenhite: ");
                int far = int.Parse(Console.ReadLine());

                int changeintocelcius = (far - 32)/39 * 5; 

                Console.Write("Change into:" + changeintocelcius);

                Console.Write("Enter Celcius: ");
                int celcius = int.Parse(Console.ReadLine());

                int changeintofarenhite = (celcius*9)/5 + 32;

                Console.Write("Change into Farenhite: " + changeintofarenhite );

        }
    }
}