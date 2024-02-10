using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Megaengine
{
    public class Window
    {
       
        private char backRound = '█';
        private static int width = 120;
        private static int height = 30;
        char[,] screen = new char[width,height];
         
        public Window(char _backround,int _width,int _height)
        {
             backRound = _backround;
             width = _width;
             height = _height;
        }
        public Window( int _width, int _height)
        {
            
            width = _width;
            height = _height;
        }
        public Window()
        {
            
        }
        
        public void Build(ConsoleColor backroundcolor)
        {
            Console.ForegroundColor= backroundcolor;
            for (int i = 0; i < width; i++)
            {
                Console.Write(backRound);
                Thread.Sleep(10);
            }
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(width - 1, i);
                Console.Write(backRound);
                Thread.Sleep(10);
            }
            for (int i = 2; i < width+1; i++)
            {
                Console.SetCursorPosition(width-i, height-1);
                Console.Write(backRound);
                Thread.Sleep(10);
            }
            for (int i = 2; i < height; i++)
            {
                Console.SetCursorPosition(0,(height)-i );
                Console.Write(backRound);
                Thread.Sleep(10);
            }
            for (int j = 1; j < width - 1; j++)
            {
                
                for (int i = 1; i < height; i++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(backRound);
                    
                }
                Thread.Sleep(10);
            }

        }
        public void ScreenBuilder(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            screen[24, 5] = 'a';
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(screen[i, j]);
                }
            }

        }
        public void CageBuilder(ConsoleColor cagecolor)
        {
            
            for (int i = 0; i < width; i++)
            {   
                Console.ForegroundColor = cagecolor;
                Console.SetCursorPosition(i,Console.CursorTop);
                Console.Write(backRound);
                Thread.Sleep(10);
            }
            for (int i = 1; i < height; i++)
            {
                Console.ForegroundColor = cagecolor;
                Console.SetCursorPosition(Console.CursorLeft, i);
                Console.Write(backRound);
                Thread.Sleep(10);
            }
            for (int i = 2; i < width + 1; i++)
            {
                Console.ForegroundColor = cagecolor;
                Console.SetCursorPosition(width - i, Console.CursorTop);
                Console.Write(backRound);
                Thread.Sleep(10);
            }
            for (int i = 2; i < height; i++)
            {
                Console.ForegroundColor = cagecolor;
                Console.SetCursorPosition(0, height - i);
                Console.Write(backRound);
                Thread.Sleep(10);
            }

        }
        public void CageBuilder(ConsoleColor cagecolor, bool fast)
        {
            if (fast==true)
            {
for (int i = 0; i < width; i++)
            {
                Console.ForegroundColor = cagecolor;
                Console.SetCursorPosition(i, 0);
                Console.Write(backRound);
                
            }
            for (int i = 1; i < height; i++)
            {
                Console.ForegroundColor = cagecolor;
                Console.SetCursorPosition(width - 1, i);
                Console.Write(backRound);
                
            }
            for (int i = 2; i < width + 1; i++)
            {
                Console.ForegroundColor = cagecolor;
                Console.SetCursorPosition(width - i, height - 1);
                Console.Write(backRound);
                
            }
            for (int i = 2; i < height; i++)
            {
                Console.ForegroundColor = cagecolor;
                Console.SetCursorPosition(0, (height) - i);
                Console.Write(backRound);
                
            }
            }
            

        }
        public void Build(ConsoleColor backroundcolor, bool fast)
        {
            Console.ForegroundColor = backroundcolor;
            if (fast == true)
            {
for (int i = 0; i < width; i++)
            {
                Console.Write(backRound);
                
            }
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(width - 1, i);
                Console.Write(backRound);
                
            }
            for (int i = 1; i < height; i++)
            {
                for (int j = 0; j < width - 1; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(backRound);
                }
            }
            }
            

        }
        public void MiddleText()
        {
            Console.SetCursorPosition(0, height / 2);
            for (int i = 0; i < width; i++)
            {
                Console.Write(backRound);
            }

            string message = "MEGAENGİNE 1.0";
            if ((width / 2) - (message.Length / 2) < 0)
            {
                Console.SetCursorPosition(50, height / 2);
            }
            else
            {
                Console.SetCursorPosition((width / 2) - (message.Length / 2), height / 2);
            }
            Console.WriteLine(message);
        }
        public void MiddleText(string message)
        {
            Console.SetCursorPosition(0, height / 2);
            for (int i = 0; i < width; i++)
            {
                Console.Write(backRound);
            }

            if ((width / 2) - (message.Length / 2) < 0)
            {
                Console.SetCursorPosition(50, height / 2);
            }
            else
            {
                Console.SetCursorPosition((width / 2) - (message.Length / 2), height / 2);
            }
            Console.WriteLine(message);

        }
    }
}
