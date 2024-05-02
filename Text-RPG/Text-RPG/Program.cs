using System.Numerics;
using System.Threading.Tasks.Dataflow;

namespace Text_RPG
{
        internal class Program
        {
            public static void Main(string[] args)
            {
                
                //Intro intro = new Intro();
                //intro.IntroScene();
               
                //Main main = new Main();
                //main.MainMenu();
                Battle battle = new Battle();
                battle.BattlePhase();
            }
            
        }
}
