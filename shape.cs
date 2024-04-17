using System;

namespace ConsoleApp1
{
    public abstract class shape
    {
        public int Weidth { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy Shape into ClipBoard");
        }
        public void Shape()
        {
            Console.WriteLine("Select the Shape");
        }


    }
}
