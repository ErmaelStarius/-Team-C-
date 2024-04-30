namespace Text_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intro intro = new Intro();
            Main main = new Main();

            intro.IntroScene();

            main.MainMenu();
        }
    }
}
