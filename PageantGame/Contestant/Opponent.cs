using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageantLibrary
{
    public class Opponent : Contestants
    {

        //ctor

        public Opponent(string hairColor, string hairStyle, string dressColor, string dressStyle)
        {
            HairColor = hairColor;
            HairStyle = hairStyle;
            DressColor = dressColor;
            DressStyle = dressStyle;
        }
        public Opponent() { }








        //methods


        public override string ToString()
        {
            // return base.ToString();
            return string.Format("{0} is her hair color\n{1} is her hair style\n{2} is her dress color\n{3} is her dress style",
                HairColor, HairStyle, DressColor, DressStyle);
        }
    }
}
