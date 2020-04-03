using System;

namespace sop1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WindowHeight = 50;
            Console.WindowWidth = 100;


            int firstPlayerColumn, firstPlayerRow, secondPlayerColumn, secondPlayerRow;



            firstPlayerColumn = 0;
            firstPlayerRow = Console.WindowHeight / 2;

            Console.SetCursorPosition(firstPlayerColumn, firstPlayerRow);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("*");


            Console.ForegroundColor = ConsoleColor.White;


            int move;
            int totalMove = 0;

            Console.SetCursorPosition(0, 47);
            Console.WriteLine("Za kolilo da se prvi igrac pomakne u desno");
            move = int.Parse(Console.ReadLine());

            firstPlayerColumn = firstPlayerColumn + move;

            Console.SetCursorPosition(firstPlayerColumn, firstPlayerRow);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("*");

            Console.ForegroundColor = ConsoleColor.White;



            totalMove = totalMove + move;





            Console.SetCursorPosition(0, 48);
            Console.WriteLine("Za kolilo da se prvi igrac pomakne gore");
            move = int.Parse(Console.ReadLine());

            firstPlayerRow = firstPlayerRow - move;

            Console.SetCursorPosition(firstPlayerColumn, firstPlayerRow);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("*");

            Console.ForegroundColor = ConsoleColor.White;



            totalMove = totalMove + move;


            Console.SetCursorPosition(0, 49);
            Console.WriteLine("Za kolilo da se prvi igrac pomakne lijevo");
            move = int.Parse(Console.ReadLine());

            firstPlayerColumn = firstPlayerColumn - move;

            Console.SetCursorPosition(firstPlayerColumn, firstPlayerRow);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("*");

            Console.ForegroundColor = ConsoleColor.White;

            secondPlayerColumn = 99;
            secondPlayerRow = Console.WindowHeight / 2;

            Console.SetCursorPosition(secondPlayerColumn, secondPlayerRow);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("*");

            Console.ForegroundColor = ConsoleColor.White;


            totalMove = totalMove + move;




            int MoveTwo;

            int totalMoveTwo = 0;

            Console.SetCursorPosition(0, 50);
            Console.WriteLine("Za kolilo da se drugi igrac pomakne u lijevo");
            MoveTwo = int.Parse(Console.ReadLine());

            secondPlayerColumn = secondPlayerColumn - MoveTwo;

            Console.SetCursorPosition(secondPlayerColumn, secondPlayerRow);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("*");

            Console.ForegroundColor = ConsoleColor.White;



            totalMoveTwo = totalMoveTwo + MoveTwo;




            Console.SetCursorPosition(0, 51);
            Console.WriteLine("Za kolilo da se drugi igrac pomakne gore");
            MoveTwo = int.Parse(Console.ReadLine());

            secondPlayerRow = secondPlayerRow - MoveTwo;

            Console.SetCursorPosition(secondPlayerColumn, secondPlayerRow);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("*");

            Console.ForegroundColor = ConsoleColor.White;


            totalMoveTwo = totalMoveTwo + MoveTwo;




            Console.SetCursorPosition(0, 52);
            Console.WriteLine("Za kolilo da se drugi igrac pomakne desno");
            MoveTwo = int.Parse(Console.ReadLine());

            secondPlayerColumn = secondPlayerColumn + MoveTwo;

            Console.SetCursorPosition(secondPlayerColumn, secondPlayerRow);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("*");

            Console.ForegroundColor = ConsoleColor.White;




            totalMoveTwo = totalMoveTwo + MoveTwo;



            Console.SetCursorPosition(0, 53);
            Console.WriteLine("Prvi igrac se pomaknuo za " + totalMove + " polja/e");
            Console.SetCursorPosition(0, 54);
            Console.WriteLine("Drugi igrac se pomaknuo za " + totalMoveTwo + " polja/e");



        }
    }
}