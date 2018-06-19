using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWith97Questions
{
    class ForOutAndRef
    {
        public string Name;
        public int Age;
        public void ForOut(out string name)
        {
            string Name = "Mirzamin";
            name = Name;
        }
        public void ForRef(ref int age)
        {
            Age = 22;
            age = Age;
        }
    }
}
