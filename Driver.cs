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
                trig obj3 = new trig();
                temp obj4 = new temp();
                Program1 obj5 = new Program1();

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

                else if( choice == "Trig" || choice =="trig")
                {
                    obj3.Trigo();
                }

                else if ( choice == "Temp" || choice == "temp")
                {
                    obj4.temperature();
                }

                else if ( choice == "Theorem" || choice == "theorem")
                {
                    obj5.theorem();
                }
        }
    }
}