using System.Numerics;
using System.Threading.Tasks.Dataflow;

namespace Text_RPG
{
    internal class Program
    {
        static private Player player;
        public static void Main(string[] args)
        {
            //Player player = new Player();
            //Battle battle = new Battle();
            //battle.BattlePhase(player);

            GameManager gameManager = new GameManager();
            gameManager.StartGame();
        }
    }
}
