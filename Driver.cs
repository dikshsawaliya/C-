using System;

namespace C_
{
    class Driver
    {
         static void Main(string [] args)
        {
                Console.Write("Input your choice = ");
                string choice = Console.ReadLine();
                Program obj = new Program();
                altitude obj1 = new altitude();
                floatintro obj2 = new floatintro();

                if(choice == "age")
                {

                int age = 21;
                Console.Write("My age is = " + age);
                
                }

                else if ( choice == "Program" || choice == "program")
                {
                    obj.prg();
                }

                else if ( choice == "Altitude" || choice == "altitude")
                {
                    obj1.altitudesub();
                }
                else if ( choice == "floatintro" || choice =="Floatintro")
                {
                    obj2.floatintoint();
                }
        }
    }
}