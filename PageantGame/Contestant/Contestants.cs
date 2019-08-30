using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageantLibrary

{
    public class Contestants
    {

        //Field

        private string _hairColor;
        private string _hairStyle;
        private string _dressColor;
        private string _dressStyle;

        //Properties

        public string HairColor
        {
            get { return _hairColor; }
            set { _hairColor = value; }
        }
        public string HairStyle
        {
            get { return _hairStyle; }
            set { _hairStyle = value; }
        }
        public string DressColor
        {
            get { return _dressColor; }
            set { _dressColor = value; }
        }
        public string DressStyle
        {
            get { return _dressStyle; }
            set { _dressStyle = value; }
        }


        //ctor

        public Contestants(string hairColor, string hairStyle, string dressColor, string dressStyle)
        {
        HairColor = hairColor;
        HairStyle = hairStyle;
        DressColor = dressColor;
        DressStyle = dressStyle;
        }
        public Contestants () { }








            //methods


            public override string ToString()
            {
            // return base.ToString();
            return string.Format("{0} is your hair color\n{1} is your hair style\n{2} is your dress color\n{3} is your dress style",
                HairColor, HairStyle, DressColor, DressStyle);
            }

            

    }//end Class
}//end Namespace
