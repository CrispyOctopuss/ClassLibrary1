using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public string Prop;

        public string Prop1
        {
            get => Prop;
            set => Prop = value;
        }

        public Class1(string p, string p1)
        {
            Prop = p;
            Prop1 = p1;
        }
    }
}