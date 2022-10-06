using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Design;
using static System.Net.Mime.MediaTypeNames;
using System.Media;

namespace MultiThread.ThreadingSamples
{
    internal class CrazyPC
    {
        public const string SoundPlayer = "\"C:\\Users\\ali_gulfaam\\Desktop\\Windows Background.wav\"";
        public static Random _random = new Random();
        public void Button_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer (SoundPlayer))
            {
                soundPlayer.PlaySync(); // can also use soundPlayer.PlaySync()
            }
        }
        public static void CrazyFunctionCall()
        {
            //int my_random_number = _random.Next(0, 100);
            //Console.WriteLine(my_random_number);
            //Console.ReadLine();
            CrazyMouseThread();
            
        }
        static void CrazyMouseThread()
        {


            //random mouse moving 
            int moveX = 0;
            int moveY = 0;
            while (true)
            {
                moveX = _random.Next(20)-10;
                Console.WriteLine(moveX);
                moveY = _random.Next(20)-10;
                Console.WriteLine(moveY);
              
                Cursor.Position = new System.Drawing.Point(Cursor.Position.X + moveX, Cursor.Position.Y + moveY);



                //random keystrokes
                Random rnd = new Random();

                string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

                while (true)
                {
                    int index = rnd.Next(alphabet.Length);
                    Console.WriteLine(alphabet[index]);
                    Thread.Sleep(300000);
                }

            }
        }
    }
}
