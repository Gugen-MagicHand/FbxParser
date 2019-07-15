using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fbx;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new FbxParser();
            var cube = parser.Parse("../../cube.fbx");
            Debug.WriteLine(cube.DumpJson());

            //using (var writer = new StreamWriter("cube.json"))
            //{
            //    writer.WriteLine(cube.DumpJson());
            //}
            var dice = parser.Parse("../../Dice.fbx");
            Debug.WriteLine(dice.DumpJson());
            //using (var writer = new StreamWriter("Dice.json"))
            //{
            //    writer.WriteLine(dice.DumpJson());
            //}


            Console.WriteLine("Press Any Key...");
            Console.ReadKey();
        }
    }
}
