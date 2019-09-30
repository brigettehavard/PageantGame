using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PageantLibrary
{
    public class Music
    {
       
            [STAThread]
            static void Main()
            {
                // First, let's determine the keys and the corresponding frequencies:
                // I have found these frequency values somewhere on the web with Google,
                // but I don't remember where exactly.
                int C = 264;
                int D = 297;
                int E = 330;
                int F = 352;
                int G = 396;
                int A = 440;
                int Bb = 466;
                int B = 495;
                int C2 = 528;

                // Now, we need to set the tempo for a note, half note, quarter note, and eighth note.
                int note = 1000;
                int half = 1000 / 2;
                int quarter = 1000 / 4;
                int eighth = 1000 / 8;

                // Now we can already "sing" a scale to warm up:
                Console.WriteLine("Warming up the voice ...");
                Thread.Sleep(2000);
                Console.Beep(C, quarter);
                Console.Beep(D, quarter);
                Console.Beep(E, quarter);
                Console.Beep(F, quarter);
                Console.Beep(G, quarter);
                Console.Beep(A, quarter);
                Console.Beep(B, quarter);
                Console.Beep(C2, half);
                Thread.Sleep(quarter);
                Console.Beep(C2, quarter);
                Console.Beep(B, quarter);
                Console.Beep(A, quarter);
                Console.Beep(G, quarter);
                Console.Beep(F, quarter);
                Console.Beep(E, quarter);
                Console.Beep(D, quarter);
                Console.Beep(C, half);
            }
        }
}
