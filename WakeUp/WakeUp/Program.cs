using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WakeUp
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 0;
            Console.WriteLine("Wake Up Lazy");
            Console.WriteLine("How often do you want to be annoyed?\nIn minutes please...");
            time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ok will do!");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                if((sw.ElapsedMilliseconds / 1000) >= time * 60)
                {
                    sw.Stop();
                    var stop = 5;
                    while (stop > 0)
                    {
                        string fileName = "PumpShotGun.wav";
                        string path = Path.Combine(Environment.CurrentDirectory, fileName);
                        SoundPlayer player = new SoundPlayer(Properties.Resources.PumpShotGun);
                        player.Load();
                        player.PlaySync();
                        stop--;
                    }
                    sw.Restart();
                }
            }
        }
    }
}
