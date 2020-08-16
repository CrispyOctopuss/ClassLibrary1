using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public string Prop { get; set; }

        public string Prop1 { get; set; }

        public Class1(string p, string p1="тестовое сообщение")
        {
            Prop = p.ToUpper();
            Prop1 = p1.ToLower();
        }
    }
}    