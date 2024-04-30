using System.Runtime.InteropServices;

namespace Text_RPG
{
    internal partial class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("적이 나타났다!");
            Battle battle = new Battle();
            battle.BattlePhase();            
        }
    }
}
