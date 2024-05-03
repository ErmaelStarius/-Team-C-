using System.Numerics;
using System.Threading.Tasks.Dataflow;

namespace Text_RPG
{
    internal class Program
    {
        private Player player;
        public static void Main(string[] args)
        {
            Title intro = new Title();
            intro.TitleScene();
       
            Main main = new Main();
            main.MainMenu();
            
        }
    }
}
