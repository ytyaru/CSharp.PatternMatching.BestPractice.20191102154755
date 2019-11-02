using System;

namespace PatternMatch
{
    class Code3
    {
        public void Run()
        {
            Console.WriteLine("===== Code3 =====");
            Console.WriteLine(Best(new Point(1,2)));
            Console.WriteLine(Bad(new Point(1,2)));
            Console.WriteLine(Bad2(null));
        }
        private string Best(Point p) => p switch {
            { } nonNull => nonNull.ToString(),
            null => "null",
        };
        string Bad(Point p) => p switch {
            null => "null",
            var other => other.ToString(),
        };
        string Bad2(Point p) => p switch {
            var other => other.ToString(),
            null => "null",
        };
    }
}
