using System.Runtime.InteropServices;

namespace Text_RPG
{
    internal partial class Program
    {
       
        static void Main(string[] args)
        {
            // 화면 해상도
            Console.SetWindowSize(250, 65);

            Intro intro = new Intro();
            Main mainmenu = new Main();

            // 인트로씬
            intro.IntroScene();

            // 메인씬
            mainmenu.MainMenu();
        }
    }
}
