using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicSkill9
{
    class Node
    {
        public Node Root = null;
        public Node Next;
        public void Push(Skill skill)
        {
            if (Root == null)
            {
                Root = skill;
            }
            else
            {
                Node ptr = Root;
                while (ptr.Next != null)
                {
                    ptr = ptr.Next;
                }
            }
        }
    }
}
