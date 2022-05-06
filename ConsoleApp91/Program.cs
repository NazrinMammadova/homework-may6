using System;

namespace ConsoleApp91
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Iletterable pdf = new Pdf ();
            Iletterable excel = new Excel();
            Iletterable word = new Word ();

            MainPrintFile pdf1 = new MainPrintFile(pdf);
            MainPrintFile excel1 = new MainPrintFile(excel);
            MainPrintFile word1 = new MainPrintFile(word);

        }
    }
}
