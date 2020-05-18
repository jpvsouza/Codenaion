using Codenation.Challenge;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fraseNormal = null;
            var bla = new CesarCypher();
            var respostta = bla.Crypt(fraseNormal);
            Console.WriteLine(respostta);

        }
    }
}
