using System;

namespace ClassicSkill9
{
    class Program
    {
        static void Main(string[] args)
        {
            string _Skillname;
            string SkillUp;
            bool isQuestion = false;
            Console.WriteLine("Input skill name: {0}", _Skillname = InputFromUser());
            if (_Skillname == "?")
            {
                while(isQuestion)
                {
                    SkillUp = Console.ReadLine();
                    if (SkillUp == "?")
                    {
                        isQuestion = true;
                    }
                    else
                    {
                        isQuestion = false;
                    }
                }   
            }
            else
            {
                Console.WriteLine("Add dependency for {0}", _Skillname);
                
            }
            Console.WriteLine("Input skill name: {0}");
            Console.WriteLine("Input skill name: {0}");
        }
        static string InputFromUser()
        {
            return Console.ReadLine();
        }
    }
}
