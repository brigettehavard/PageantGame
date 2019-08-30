using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageantLibrary;//added
using System.Threading;//added


namespace PageantGame
{
    class Pageant
    {
        static void Main(string[] args)
        {
            //Kendras rainbow code
            ConsoleColor[] gay = { ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.DarkMagenta };
            char[] test = "Welcome To Sparkle and Shine National Pageant!!!!".ToCharArray();
            byte box = 0; for (int i = 0; i < test.Length; i++)
            {
                if (test[i] != ' ')
                { Console.ForegroundColor = gay[box++ % gay.Length]; }
                Console.Write(test[i]);
            }

            //kendras rainbow code

            Console.ResetColor();
            

            Console.WriteLine("\n\n");


            Console.ForegroundColor = ConsoleColor.Yellow;
            //TODO enter the rules and objectives of the game
            Console.WriteLine("So you decided to enter a pageant???\nIt is alot more work than you probably think!\n" +
                "First let me Introduce myself!\nMy name is PHOEBE and I am officially your Pageant Coach!!\n" +
                "Our goal is to get you to Nationals and ultimatly win THE CROWN!!!!\n" +
                "To do that you have to win a Prelim.\nWinning a prelim then qualifies you to go to the State Pageant.\nThen" +
                " you must win State and finally you will make it to Nationals!!\nWe have alot of work to do but I am excited to work" +
                " with you!!!");

            

            Console.WriteLine();
            Console.ResetColor();


            Console.WriteLine("First, What is your name?");
            string playerName = Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine("\n\nWelcome " + playerName + "!!!...Now, we must get you ready by making sure you have the perfect hair and dress!");


           
            Console.WriteLine("\nFirst " + playerName + ", Pick your Hair color by selecting the number:\n \n1) Blonde \n2) Brunette \n3) Black \n4) Red");
                    string contHairColor = Console.ReadLine().ToUpper();
           

                    switch (contHairColor)
                    {
                        case "1":
                            contHairColor = "Blonde";
                            break;
                        case "2":
                            contHairColor = "Brunette";
                            break;
                        case "3":
                            contHairColor = "Black";
                            break;
                        case "4":
                            contHairColor = "Red";
                            break;

                        default:
                            Console.WriteLine("That was not a selection, please try again");
                   
                        
                            break;

                    }
            Console.Clear();
            



            Console.WriteLine("\nNow pick a Hair Style, please select a number:\n\n1) Curly Updo, \n2) Hair down and Straight," +
                    " \n3) Hair down and curly \n4) Princess Bun \n5) Hair half up and half down");
                    string contHairStyle = Console.ReadLine();
                    switch (contHairStyle)
                    {
                        case "1":
                            contHairStyle = "Curly Updo";
                            break;
                        case "2":
                            contHairStyle = "Hair down and straight";
                            break;
                        case "3":
                            contHairStyle = "Hair down and curly";
                            break;
                        case "4":
                            contHairStyle = "Princess Bun";
                            break;
                        case "5":
                            contHairStyle = "hair half up and half down";
                            break;
                        default:
                            Console.WriteLine("That was not an option, please try again");
                            break;
                    }
            Console.Clear();


                    Console.WriteLine("\nSelect a dress color now:\n \n1) Red\n2) Blue\n3) Purple\n4) Yellow\n5) Pink\n6) Green\n7) Orange\n8) White\n9) Black");
                    string contDressColor = Console.ReadLine().ToUpper();
                    switch (contDressColor)
                    {
                        case "1":
                            contDressColor = "Red";
                            break;
                        case "2":
                            contDressColor = "Blue";
                            break;
                        case "3":
                            contDressColor = "Purple";
                            break;
                        case "4":
                            contDressColor = "Yellow";
                            break;
                        case "5":
                            contDressColor = "Pink";
                            break;
                        case "6":
                            contDressColor = "Green";
                            break;
                        case "7":
                            contDressColor = "Orange";
                            break;
                        case "8":
                            contDressColor = "White";
                            break;
                        case "9":
                            contDressColor = "Black";
                            break;
                        default:
                            Console.WriteLine("That was not an option, please select again");
                            break;
                    }
            Console.Clear();


                    Console.WriteLine("\nFinally select a Dress Style, please select a number:\n \n1) Long\n2) Short \n3) Hi-Low");
                    string contDressStyle = Console.ReadLine().ToUpper();
                    switch (contDressStyle)
                    {
                        case "1":
                            contDressStyle = "Long Dress";
                            break;
                        case "2":
                            contDressStyle = "Short Dress";
                            break;
                        case "3":
                            contDressStyle = "High Low Dress";
                            break;
                        default:
                            Console.WriteLine("That was not an option please try again");
                            break;
                    }
            Console.Clear();

            //TODO make loops for the "That is not an option please select again"
            


                   

                    Contestants c1 = new Contestants();
                    c1.HairColor = contHairColor;
                    c1.HairStyle = contHairStyle;
                    c1.DressColor = contDressColor;
                    c1.DressStyle = contDressStyle;

           
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("\nYour contestant features are:\n\n");
            Console.WriteLine(c1);



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + playerName + ", YOU ARE NOW READY FOR THE PRELIMINARY PAGEANT!");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\nUh Oh, Your competition just walked in!!");

            Thread.Sleep(200);

            //These are the opponents randoms selections:
            #region HAIR COLOR
            //OPPONENTS HAIR COLOR

            HairColor[] oppHairColor = { HairColor.Black, HairColor.Blonde, HairColor.Brunette, HairColor.Red };
            //Randomly select the opponents hair color

            Random rand = new Random();
            int randomHairColor = rand.Next(oppHairColor.Length);

            HairColor hairColor = oppHairColor[randomHairColor];

            Console.WriteLine();

            #endregion

            #region HAIR STYLE
            //OPPONENTS HAIR STYLE


            HairStyle[] oppHairStyle = { HairStyle.Curly_Updo, HairStyle.Down_Curly , HairStyle.Down_Straight,
                HairStyle.Half_Up_Half_Down, HairStyle.Princess_Bun };
            

            Random rand2 = new Random();
            int randomHairStyle = rand.Next(oppHairStyle.Length);

            HairStyle hairStyle = oppHairStyle[randomHairStyle];

            Console.WriteLine();

            #endregion

            #region DRESS COLOR
            //OPPONENTS DRESS COLOR


            DressColor[] oppDressColor = { DressColor.Black, DressColor.Blue, DressColor.Green, DressColor.Orange, DressColor.Pink,
            DressColor.Purple, DressColor.Red, DressColor.White, DressColor.Yellow};


            Random rand3 = new Random();
            int randomDressColor = rand.Next(oppDressColor.Length);

            DressColor dressColor = oppDressColor[randomDressColor];

            Console.WriteLine();

            #endregion

            #region DRESS STYLE
            //OPPONENTS DRESS STYLE


            DressStyle[] oppDressStyle = { DressStyle.High_Low_Dress, DressStyle.Long_Dress, DressStyle.Short_Dress};


            Random rand4 = new Random();
            int randomDressStyle = rand.Next(oppDressStyle.Length);

            DressStyle dressStyle = oppDressStyle[randomDressStyle];

            Console.WriteLine();

            #endregion

            Opponent o1 = new Opponent();
            o1.HairColor = hairColor.ToString();
            o1.HairStyle = hairStyle.ToString();
            o1.DressColor = dressColor.ToString();
            o1.DressStyle = dressStyle.ToString();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hmm she looks like a strong competitor!!");
            Console.WriteLine(o1);

            
          
            Console.WriteLine("\n\n" + playerName + " Are you nervous, Yes or No?");

            string userAnswer = Console.ReadLine().ToUpper();

            switch (userAnswer)
            {
                case "Y":
                case "YES":
                    Console.WriteLine("\n{0}, don't be nervous!  You've got this!", playerName);
                    break;
                case "N":
                case "NO":
                    Console.WriteLine("Good for you!  I'm proud of your confidence!");
                    break;
                default:
                    Console.WriteLine("well you must be so nervous you cant even type yes or no!  That's ok!  I believe in you!");
                    break;
            }
            Console.Clear();



            
            
            
            


        



            //TODO have them compete in beauty:
            //use Beeps to play a tune.


            //TODO: introduce 3 judges:
            //Create like 10 judges

            Console.WriteLine("Now lets meet our 3 judges!");

            #region JUDGES


            Judges j1 = new Judges();
            j1.JudgeNumber = "1";
            j1.Name = "Loretta";
            j1.Description = "A 65 year old lady from Nebraska.  She is a mean ol' lady that loves her 12 cats but doesnt like children.";

            Judges j2 = new Judges("2", "Tom", "A hair dresser from Texas.");
            Judges j3 = new Judges("3", "Mary", "A kindergarten teacher from Missouri");
            Judges j4 = new Judges("4", "Betty Sue", "Miss Buttercream Fair 1989");

            Judges[] currentJudges = { j1, j2, j3, j4 };
            //Randomly select the opponents hair color

            Random rand5 = new Random();
            int randomJudge = rand.Next(currentJudges.Length);

            Judges judges = currentJudges[randomJudge];

            Console.WriteLine();

            #endregion

            //FIX why it gives every judge the number of 0

            Console.WriteLine("Here is the first judge, " + judges.ToString());
            Console.WriteLine("Here is the next judge, " + judges.ToString());
            Console.WriteLine("Here is the final judge, is " + judges.ToString());



            //TODO: have the 3 judges score them in the 4 categories PLUS a sparkle category.
            //....Each judge will randomly score 1-10 in each category:
            /*
             EXAMPLE:  judge 1 may give you a:
             7 in hair color
             6 in hair style
             8 in dress color
             9 in dress style
             10 in sparkle points
             total score from judge 1: 40/50
            */
            //This will give the contestants a possible score of 150
            //Top score wins


            //EVENTUALLY I CAN ADD NEW EVENTS: swim wear, casual wear: wear contestant picks outfit color, accesories, etc.
            //OR eventually move from prelim, state, then nationals!






        }//end Main()
    }//end Class
}//end Namespace
