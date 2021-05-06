using System;

namespace ApplicationClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived(); // 업캐스팅 de -> ab
            Derived obj1 = (Derived)obj; // 다운캐스팅 ab -> de

            obj.PublicMethod();
            obj.AbstractMethod();
            obj1.DerivedMethod();
        }
    }
}
