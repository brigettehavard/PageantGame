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

        private int _number;
        private string _name;
        private string _description;

        //Properties

        
        public string Name { get; set; }
        public string Description { get; set; }

        //ctor
        public Judges(string name, string description)
        {
            
            Name = name;
            Description = description;
        }

        public Judges () { }

        //methods

        public override string ToString()
        {
            return string.Format("Judge name is {0}.  {1}", Name, Description);

        }


    }
}
