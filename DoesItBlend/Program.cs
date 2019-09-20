using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendable> blendStuff = new List<IBlendable>();
            blendStuff.Add(new Strawberry());
            blendStuff.Add(new Banana());
            blendStuff.Add(new CellPhone());
            blendStuff.Add(new IceCubes());

            for (int i =0; i<10; i++)
                blendStuff.Add(new Mango());

            string mess = "";
            foreach (IBlendable o in blendStuff)
            {
                mess += o.Blend();
                mess += ", ";
            }

            Console.WriteLine(mess);

        }
    }
}
