using System;
using System.Threading;
using System.IO;
using System.Media;

namespace weLiveWeLoveWeLie {
  class Program {
    static void Main(string[] args) {

      string soundPath = "G:\\My Drive\\Self Learning\\c#\\Others\\weLoveWeLiveWeLie\\Spectre.wav";
      SoundPlayer player = new SoundPlayer(soundPath);
      player.Play();
      
      Console.WriteLine("Ready?");
      Console.ReadKey();

      Console.WriteLine("We Live...");
      
      Thread.Sleep(1250);
      Console.WriteLine("We Love...");

      Thread.Sleep(1000);
      Console.WriteLine("We Lie...");

      Thread.Sleep(100);
      string filePath = "G:\\My Drive\\Self Learning\\c#\\Others\\weLoveWeLiveWeLie\\spectreAscii.txt";
      
      if (File.Exists(filePath)) {
        string content = File.ReadAllText(filePath);

        try {
          
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine(content);
        } catch (Exception e) {
          Console.WriteLine(e.Message);
        }

      } else {
        Console.WriteLine("Error");
      }

            Console.ReadKey();
      Console.ForegroundColor = ConsoleColor.White;

    }
  }
}