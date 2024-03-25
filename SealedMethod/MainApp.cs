using System;

class Base
{
    public virtual void SealMe()
    {
    }

    class Derived : Base
    {
        public sealed override void SealMe()
        {
        }
    }

    class Ob : Derived
    {
        public override void SealMe()
        {
            // 위에서 봉인했기 때문에 여기서 오류남
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {

        }
    }
}