using System;

namespace PatternMatch
{
    class Code2
    {
        public void Run()
        {
            Console.WriteLine("===== Code2 =====");
            Console.WriteLine($"{Bad("ABC")}"); // 0
            Console.WriteLine($"{Best("ABC")}"); // 0
        }
        private int Bad(object obj) => obj switch
        {
            string s when s.Length == 0 => 0,
            string s when s.Length == 0 => 1, // 条件重複！
            _ => -1,
        };
        private int Best(object obj) => obj switch
        {
            string { Length: 0 } => 0,
            string { Length: 0 } => 1, // 条件重複！　コンパイルエラーで通知してくれる
            _ => -1,
        };
    }
}
