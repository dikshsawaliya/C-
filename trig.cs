using System;

namespace C_
{
    class trig
    {
        public static void Trigonometry(String[] args)
        {
                float sin = (float) Math.Sin(90 * Math.PI / 180);
                float cosine = (float)Math.Cos(90 * Math.PI/180);

                Console.Write("Sin value is: " + sin);
                Console.Write("Cosine value is" + cosine);
        }
    
    }
}
