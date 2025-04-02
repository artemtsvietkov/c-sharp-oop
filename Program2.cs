using System;

namespace AstrodroidApp
{
    public abstract class Astrodroid
    {
        public virtual string GetSound()
        {
            return "Beep beep";
        }

        public void MakeSound()
        {
            Console.WriteLine(GetSound());
        }
    }

    public class R2 : Astrodroid
    {
        public override string GetSound()
        {
            return "Beep boop";
        }
    }

    class Program2
    {
        static void RunAstrodroidApp(string[] args)
        {
            R2 r2Droid = new R2();
            Console.WriteLine("Ljud från R2-droid:");
            r2Droid.MakeSound();

            Astrodroid astroDroid = new R2();
            Console.WriteLine("\nLjud från Astrodroid-referens (som pekar på R2):");
            astroDroid.MakeSound();
        }
    }
}