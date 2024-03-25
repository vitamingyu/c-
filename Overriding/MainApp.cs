using System;

namespace Overriding
{
    class ArmorSuit
    {
        public virtual void Initialize()
        {
            Console.WriteLine("방어모드 실행, 갑바 장착");
        }
    }

    class IronMan : ArmorSuit
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("아이언맨 수트 장착");
        }
    }

    class WarMachine : ArmorSuit
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("무기 장착");
            Console.WriteLine("로켓펀치 장착");
        }
    }

    internal class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating AromorSuit...");
            ArmorSuit armorSuit = new ArmorSuit();
            armorSuit.Initialize();

            Console.WriteLine("\nCreating IronMan...");
            ArmorSuit ironman = new IronMan();
            ironman.Initialize();

            Console.WriteLine("\nCreating WarMachine...");
            ArmorSuit warmachine = new WarMachine();
            warmachine.Initialize();
        }
    }
}
