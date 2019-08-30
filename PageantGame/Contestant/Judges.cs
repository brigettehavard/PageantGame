using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageantLibrary
{
    public class Judges
    {
        //create the judges

        //field

        private string _judgeNumber;
        private string _name;
        private string _description;

        //Properties

        public string JudgeNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //ctor
        public Judges(string judgeNumber, string name, string description)
        {
            JudgeNumber = JudgeNumber;
            Name = name;
            Description = description;
        }

        public Judges () { }

        //methods

        public override string ToString()
        {
            return string.Format("Judge number {0} is {1}.  {2}", JudgeNumber, Name, Description);

        }


    }
}
