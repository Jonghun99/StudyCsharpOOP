using System;

namespace ApplicationClassTestApp
{
    class Derived : AbstractBase
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived.AbstractMethod() 실행");
            base.ProtectedMethod();
        }

        public void DerivedMethod()
        {
            Console.WriteLine("Derived.PublicMethod() 실행");
        }
    }
}
