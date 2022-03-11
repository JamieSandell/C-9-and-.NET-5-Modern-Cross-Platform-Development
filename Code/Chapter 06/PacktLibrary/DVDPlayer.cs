using static System.Console;

namespace Packt.Shared
{
    public class DVDPlayer : IPlayable
    {
        public void Pause()
        {
            WriteLine("DVD player is pausing.");
        }
        public void Play()
        {
            WriteLine("DVD player is playing.");
        }
        void Stop() // default interface implementation, allowed in C# 8 and later
        {
            WriteLine("Default implementation of Stop.");
        }
    }
}