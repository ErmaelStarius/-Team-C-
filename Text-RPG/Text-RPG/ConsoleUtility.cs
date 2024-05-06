namespace Text_RPG
{
    internal class ConsoleUtility
    {
        


        public static ConsoleKey PromptChoice()
        {

            Images images = new Images();

            while (true)
            {
                ConsoleKeyInfo InputKey = Console.ReadKey();

                if (InputKey.Key == ConsoleKey.Z)
                {
                    return ConsoleKey.Z;
                }
                else if(InputKey.Key == ConsoleKey.X)
                {
                    return ConsoleKey.X;
                }

                // 에러
                Console.Clear();
                images.Error();
            }
        }


        internal static void ShowTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(title);
            Console.ResetColor();
        }
        public static void PrintTextHighlights(string s1, string s2, string s3 = "")
        {
            Console.Write(s1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(s2);
            Console.ResetColor();
            Console.WriteLine(s3);
        }

        public static int GetPrintableLength(string str)
        {
            int length = 0;
            foreach (char c in str)
            {
                if (char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)
                {
                    length += 2; // 한글과 같은 넓은 문자에 대해 길이를 2로 취급
                }
                else
                {
                    length += 1; // 나머지 문자에 대해 길이를 1로 취급
                }
            }

            return length;
        }

        public static string PadRightForMixedText(string str, int totalLength)
        {
            int currentLength = GetPrintableLength(str);
            int padding = totalLength - currentLength;
            return str.PadRight(str.Length + padding);
        }
    }
}