using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingIsAwesome
{
    class Program   //  Not Awesome
    {
        static void Main(string[] args)
        {
            var awesomeCounter = 0;
            
            var newEmmet = new Emmet();
           
            Console.WriteLine(newEmmet.IAmAwesome());
            Console.WriteLine(newEmmet.LegoIsAwesome());
            Console.WriteLine(newEmmet.EmmetIsAwesome());
            if (newEmmet is Awesome)
            {
                awesomeCounter++;
            }
            Console.WriteLine("..................................");

            IBrick brick = new RedBrick();
            Console.WriteLine(brick.BricksAreAwesome());

            if (brick is Awesome)
            {
                awesomeCounter++;
            }

            Console.WriteLine("..................................");
            Console.WriteLine("Creating a list of bricks, please wait...");
            Console.WriteLine("..................................");


            List<IBrick> bricks = new List<IBrick>();
            bricks.Add(new RedBrick());
            bricks.Add(new BlackBrick());
            foreach (IBrick item in bricks)
            {
                Console.WriteLine(item.BricksAreAwesome());

                if (item is RedBrick)
                {
                    var redBrick = ((RedBrick)item);
                    Console.WriteLine(redBrick.EveryRedBrickIsAwesome());
                    Console.WriteLine(redBrick.LegoIsAwesome());
                    Console.WriteLine(redBrick.IAmAwesome());
                    Console.WriteLine("..............................");
                }
                if (item is BlackBrick)
                {
                    var blackBrick = ((BlackBrick)item);
                    Console.WriteLine(blackBrick.EverythingIsAwesome());
                    Console.WriteLine(blackBrick.LegoIsAwesome());
                    Console.WriteLine(blackBrick.IAmAwesome());
                    Console.WriteLine("..............................");
                }
                if (item is Awesome)
                {
                    awesomeCounter++;
                }
                
            }


            Console.WriteLine("There are {0} awesome objects!", awesomeCounter.ToString());
            Console.ReadLine();
        }

        
    }
}
