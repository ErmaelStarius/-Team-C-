using System.Runtime.InteropServices;

namespace Text_RPG
{
    internal partial class Program
    {
       
        static void Main(string[] args)
        {
            Console.SetWindowSize(250, 65);
            Intro intro = new Intro();
            Main main = new Main();

            intro.IntroScene();
            main.MainMenu();
            
        }
    }
}
