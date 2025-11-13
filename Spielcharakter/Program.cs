using System;

namespace SpielcharakterMVC
{
    class Program
    {
        static void Main(String[] args)
        {
            // Ein allgemeiner Charakter
            Charakter held = new Charakter("Arthos", 100, "Leder", 3);
            Magier zauberer = new Magier("Gandalf", 100, "Stoff", 2, 100, 3);
            Krieger kaempfer = new Krieger("Olaf", 100, "Platte", 5, 100);
            // Methodenaufrufe
            held.Action();
            zauberer.Action();
            kaempfer.Action();


        }
    }
}
