using System.Numerics;
using System.Threading.Tasks.Dataflow;

namespace Text_RPG
{
        internal class Program
        {
            
            public static void Main(string[] args)
            {

            //StartGame();
               
                Battle battle = new Battle();
                battle.BattlePhase();

            }

            //private static void StartGame()
            //{
                //new Intro().IntroScene();
                
            //}
        }
}
