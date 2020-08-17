using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public string Name1 { get; set; }

        public string Name2 { get; set; }

        public Class1(string p, string p1="тестовое сообщение")
        {
            Name1 = p.ToUpper();
            Name2 = p1;
        }
    }
}    