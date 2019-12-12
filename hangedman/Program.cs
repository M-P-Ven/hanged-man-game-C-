using System;

namespace hangedman
{
    class Program
    {
        static int guesscounter = 0;
        static string playerletter = "z";
        static char[] maskedword = { 'l','o','u','d'};
        static string anwerword;
        static int a = 0;
        static bool stop = false;
        static void Main(string[] args)
        {
            string pname;
            pname = AskForUserName();
            Startgame(pname);
            Playgame();
            Endgame(pname);
        }
        //main end

        private static void Startgame(string pname)
        {
            Console.WriteLine($"welcome {pname} , and i hope you enjoy my game");
        }
        //startgame end

        private static string AskForUserName()
        {
            bool pnlength;
            string playername;
            Console.WriteLine("informe sue nome:");
            playername = Console.ReadLine();
            if (playername.Length > 1)
                pnlength = true;
            else
                pnlength = false;
            if (pnlength == true)
                return playername;
            else
                return playername = AskForUserName();

        }
        //askforusername end

        private static void Playgame()
        {
            MaskedWord();
            do
            {
                AskedLetter();
                MaskedWord();
            } while(stop == false);
        }
        //playgame end

        private static void AskedLetter()
        {
            do
            {
                Console.WriteLine("\n informe uma letra:");
                playerletter = Console.ReadLine();
                guesscounter++;
            } while (playerletter.Length != 1);
        }
        //askedletter end
        private static void MaskedWord()
        {
            for (int i = 0; i < maskedword.Length; i++)
            {
                char t = (char)maskedword[i];
                if (t == char.Parse(playerletter))
                {
                    anwerword += t;
                    a = anwerword.Length;
                    Console.Write(anwerword);
                }
                else
                {
                    Console.Write('-');
                }
                if (maskedword.Length == a)
                    stop = true;
            }
        }
        //askedletter end

        private static void Endgame(string pname)
        {
            Console.WriteLine($"\nThank you for playing my game {pname}!");
            Console.WriteLine($"\nTotal number of gesses:{guesscounter}");
            Console.WriteLine("ending the game...");
        }
        //endgame end

        //method end
    }
    //class end
}
//namespace end
