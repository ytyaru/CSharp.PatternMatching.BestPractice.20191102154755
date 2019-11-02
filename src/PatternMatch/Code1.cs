using System;

namespace PatternMatch
{
    class Code1
    {
        public void Run()
        {
            Console.WriteLine("===== Code1 =====");
            Console.WriteLine($"{Bad(new Point(1,2))}");
            Console.WriteLine($"{Best(new Point(1,2))}");
        }
        private int Bad(object x) => x switch
        {
            Point(1, 2) => 0,
            _ => -1,
        };
        private int Best(Point p) => p switch
        {
            (1, 2) => 0,
            _ => -1,
        };
    }
}
