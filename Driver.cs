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
                Hello obj1 = new Hello();

                if(choice == "age")
                {

                int age = 21;
                Console.Write("My age is = " + age);
                
                }

                else if ( choice == "Program")
                {
                    obj.prg();
                }

                else if ( choice == "Hello" || choice == "hello")
                {
                    obj1.hello();
                }

                if(choice == "program")
                {
                        obj.prg();
                }
        }
    }
}