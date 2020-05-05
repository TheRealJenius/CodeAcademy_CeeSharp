using System;

namespace Build_A_Creature
{
    class Program
    {
        static void Main(string[] args)
        {
          RandomMode();
          BuildACreature("ghost", "bug", "monster");
        }

        static void SwitchCase(int head, int body, int feet)
        {
          switch (head)
          {
            case 1:
              GhostHead();
              break;

            case 2:
              BugHead();
              break;

            case 3:
              MonsterHead();
              break;

            default:
            break;
          }

          switch (body)
          {
            case 1:
              GhostBody();
              break;

            case 2:
              BugBody();
              break;

            case 3:
              MonsterBody();
              break;

            default:
            break;
          }

          switch (feet)
          {
            case 1:
              GhostFeet();
              break;

            case 2:
              BugFeet();
              break;

            case 3:
              MonsterFeet();
              break;

            default:
            break;
          }
        }

        static int TranslateToNumber(string creature)
        {
          switch (creature)
          {
            case "ghost":
              return 1; // apparently you can use either break or return to end a switch statment so the error CS0162 does not appear


            case "bug":
              return 2;


            case "monster":
              return 3;
    

            default:
              return 1;
    
          }
        }

        static void BuildACreature(string head, string body, string feet)
        {
          SwitchCase(TranslateToNumber(head),TranslateToNumber(body),TranslateToNumber(feet));
        }

        static void RandomMode()
        {
          Random randomNumber = new Random();
          int ranHead = randomNumber.Next(1,4);
          int ranBody = randomNumber.Next(1,4);
          int ranFeet = randomNumber.Next(1,4);
          SwitchCase(ranHead,ranBody,ranFeet);

        }

        static void GhostHead()
        {
          Console.WriteLine("     ..-..");
          Console.WriteLine("    ( o o )");
          Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
          Console.WriteLine("    |     |");
          Console.WriteLine("    |     |");
          Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
          Console.WriteLine("    |     |");
          Console.WriteLine("    |     |");
          Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
          Console.WriteLine("     /   \\");
          Console.WriteLine("     \\. ./");
          Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
          Console.WriteLine("  --|  |  |--");
          Console.WriteLine("  --|  |  |--");
          Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
          Console.WriteLine("     v   v");
          Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
          Console.WriteLine("     _____");
          Console.WriteLine(" .-,;='';_),-.");
          Console.WriteLine("  \\_\\(),()/_/");
          Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
          Console.WriteLine("   ,-/`~`\\-,___");
          Console.WriteLine("  / /).:.('--._)");
          Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
          Console.WriteLine("    |  Y  |");
          Console.WriteLine("   /   |   \\");
          Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
