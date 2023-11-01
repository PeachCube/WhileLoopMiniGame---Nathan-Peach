using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopMiniGame___Nathan_Peach
{
    internal class Program
    {
            //VARIABLE DECLARATION & INITIALIZATION//
            
            static bool gameOver = false;
            //whether or not the game has ended.
            
            
            static int x = 0;
            static int y = 0;
            //player coordinates on a 2-dimensional plane.

            //VARIABLE DECLARATION & INITIALIZATION//
        static void Main(string[] args)
        {


            //GAME LOOP//

            Console.ForegroundColor = ConsoleColor.Green;
            while (gameOver == false) //functions similarly to "void Update()" in Unity. The code inside this while loop will attempt to execute every frame (assuming the condition is true).
            {
                //pressing escape sets gameOver to true, which closes the while loop.
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    gameOver = true;
                }
                PlayerDraw(x, y);
                PlayerUpdate();
                
                if (x > 119)
                {
                    x = 119;
                }
                else if (x < 0)
                {
                    x = 0;
                }
                if (y > 29)
                {
                    y = 29;
                }
                else if (y < 0)
                {
                    y = 0;
                }
            //I think this is probably an example of "hard coding", since the cursor does stay within the bounds of the screen, but only if the screen doesn't change size. 
            }
        }
        static void PlayerDraw(int x, int y) //updates the visual position of the character based on their x & y coordinates.
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("O");
        }
        static void PlayerUpdate() //updates the actual values of the player coordinates through user input.
        {
            ConsoleKeyInfo playerInput; //declaring the "ConsoleKeyInfo" variable playerInput to detect and store the value of the most recent key press.
            playerInput = Console.ReadKey(true); //initializing the playerInput variable. playerInput is equal to the last key press read in the console window.
            if (playerInput.Key == ConsoleKey.W)
            {
                y -= 1;
            }
            //for some reason, adding 1 to the y coordinates makes it go downward instead of upward, but the same doesn't happen with the x coordinates.
            //I think the grid that the window exists in is mirrored about the x axis or something, so the text can start from the top and move downwards like expected.
            if (playerInput.Key == ConsoleKey.S) 
            {
                y += 1;
            }
            if (playerInput.Key == ConsoleKey.A)
            {
                x -= 1;
            }
            if (playerInput.Key == ConsoleKey.D)
            {
                x += 1;
            }
        }
    }
}
