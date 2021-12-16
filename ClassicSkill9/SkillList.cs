using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicSkill9
{
    class SkillList
    {
        public static List<Skill> listSkill = new List<Skill>();
        public void Add(Skill skill)
        {
            listSkill.Add(skill);
        }
    }
}
