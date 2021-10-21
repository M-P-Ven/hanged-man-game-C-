using System;

namespace hangedman
{
    class Program
    {//abaixo sao as variaveis globais para facilitar o desenvolvimento do jogo
        static int guesscounter = 0;
        
        //static char  TRY;
        static string playerletter;
        static string playerguesses = string.Empty;
        static bool gameover=false;
        static string playercorrectguess=string.Empty;
        static int lettercount=0;
        static string masked = "world";
        static void Main(string[] args)
        {
            string pname;
            pname = AskForUserName();
            Startgame(pname);
            Playgame();
            Endgame(pname);
        }
        //main end

        private static void Startgame(string pname)//funçao para colocar coisas antes do jogo começar, por enquanto so tem uma frase mas pode colocar um menu por exemplo
        {
            Console.WriteLine($"welcome {pname} , and i hope you enjoy my game, you have 10 chances do guess the letters of the secret word");
        }
        //startgame end

        private static string AskForUserName()//funçao para requisitar um nome, dando para editar o tamanho minimo e maximo
        {
            bool pnlength;
            string playername;
            Console.WriteLine("informe sue nome:");
            playername = Console.ReadLine();
            Console.WriteLine(playername);
            if (playername.Length > 2)
                pnlength = true;
            else
                pnlength = false;
            if (pnlength == true) 
                return playername;
            else
                Console.WriteLine("nome invalido"); 
                return playername = AskForUserName();
        }
        //askforusername end

        private static void Playgame()//funçao que chama todas as funçoes nescessarias para o jogo de forca, deixa o main mais limpo por nao estar cheio de coisas
        {
            Console.WriteLine("playing the game...");
            lettercount = masked.Length;
            lettercount = 2*lettercount;
            System.Console.WriteLine(lettercount);
            do{
            MaskedWord();
            AskedLetter();
            if(guesscounter >= lettercount || string.Equals(masked,playercorrectguess)){
                gameover=true;
            }
            }while(gameover != true);
        }
        //string.Equals(masked,playercorrectguess)
        //playgame end

        private static void AskedLetter()
        {
            do
            {
                Console.WriteLine("\n informe uma letra:");
                playerletter = Console.ReadLine();
                guesscounter++;
            } while (playerletter.Length != 1);
            foreach (char t in masked)
            {
                if (playerletter.Contains(t))
                {
                    playercorrectguess = playercorrectguess + playerletter;
                }
            }      
            playerguesses = playerguesses+playerletter;
            System.Console.WriteLine(playerguesses);
        }
        //askedletter end
        private static void MaskedWord()
        {
            foreach (char t in masked)
            {
                foreach(char p in playercorrectguess){
                    if(string.Equals(t,p)){
                        System.Console.WriteLine(p);
                        break;
                    }else{
                        Console.Write('-');
                    }
                }
            }
        }
        //askedletter end

        private static void Endgame(string pname)//mesma ideia da funçao startgame, porem esta executa no final
        {
            Console.WriteLine($"Thank you for playing my game, {pname}!");
            Console.WriteLine($"Total number of gesses:{guesscounter}");
            Console.WriteLine("ending the game.");
        }
        //endgame end

        //method end
    }
    //class end
}
//namespace end
