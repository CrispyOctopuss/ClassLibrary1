using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public string Name1 { get; set; }

        public string Name2 { get; set; }

        public Class1(string n1, string n2="тестовое сообщение")
        {
            Name1 = n1.ToUpper();
            Name2 = n2;
        }
    }
}    