using System;

namespace PatternMatch
{
    class Code0
    {
        public void Run()
        {
            Console.WriteLine("===== Code0 =====");
            Bad(0);
            Console.WriteLine(Best(0));
        }
        private void Bad(object x)
        {
            switch (x) {
                case 0:
                    Console.WriteLine("Case 0");
                    break;
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                default:
                    Console.WriteLine("Case default");
                    break;
            }
        }
        private string Best(object x) => x switch
        {
            0 => "Case 0",
            1 => "Case 1",
            _ => "Case default",
        };
    }
}
