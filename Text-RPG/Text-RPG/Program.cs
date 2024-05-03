using System.Numerics;
using System.Threading.Tasks.Dataflow;

namespace Text_RPG
{
    internal class Program
    {
        static private Player player;
        public static void Main(string[] args)
        {
            Intro intro = new Intro();
            intro.IntroScene();
        }
    }
}
