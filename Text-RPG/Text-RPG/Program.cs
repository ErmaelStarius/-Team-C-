using System.Runtime.InteropServices;

namespace Text_RPG
{
    internal partial class Program
    {
       
        static void Main(string[] args)
        {
            // ȭ�� �ػ�
            Console.SetWindowSize(250, 65);

            Intro intro = new Intro();
            Main mainmenu = new Main();

            // ��Ʈ�ξ�
            intro.IntroScene();

            // ���ξ�
            mainmenu.MainMenu();
        }
    }
}
