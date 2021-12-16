using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicSkill9
{
    class Skill : Node
    {
        public Node Left;
        public Node Right;
        public string Name;
        public Skill(string name, Node left, Node right)
        {
            Name = name;
            Left = left;
            Right = right;
        }
    }
}
