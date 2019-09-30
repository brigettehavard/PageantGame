using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageantLibrary
{
    public class Score
    {

        //field

        private int _hairColorScore;
        private int _hairStyleScore;
        private int _dressColorScore;
        private int _dressStyleScore;
        private int _sparkleScore;
        private int _totalScore;

        //properties
        public int HairColorScore { get; set; }
        public int HairStyleScore { get; set; }
        public int DressColorScore { get; set; }
        public int DressStyleScore { get; set; }
        public int SparkleScore { get; set; }
        public int TotalScore { get; set; }//Might be a business rule???

        //ctor

        public Score(int hairColorScore, int hairStyleScore, int dressColorScore, int dressStyleScore, int sparkleScore, int totalScore)
        {
            HairColorScore = hairColorScore;
            HairStyleScore = hairColorScore;
            DressColorScore = dressColorScore;
            DressStyleScore = dressColorScore;
            SparkleScore = sparkleScore;
            TotalScore = totalScore;
        
        }
        public Score() { }

        //methods

        public override string ToString()
        {
            return string.Format("The hair color score is {0}\nthe hair style score is {1}\nthe dress color score is {2}\n" +
                "the dress style score is {3}\nthe sparkle score is {4}\n\n", HairColorScore, HairStyleScore, DressColorScore, DressStyleScore,
                SparkleScore);
        }


    }
}
