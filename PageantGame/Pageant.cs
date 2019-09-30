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
            //Rainbow Code
            ConsoleColor[] gay = { ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.DarkMagenta };
            char[] test = "Welcome To Sparkle and Shine National Pageant!!!!".ToCharArray();
            byte box = 0; for (int i = 0; i < test.Length; i++)
            {
                if (test[i] != ' ')
                { Console.ForegroundColor = gay[box++ % gay.Length]; }
                Console.Write(test[i]);
            }

            //End rainbow code

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
            string playerName = Console.ReadLine().ToUpper();
            
            Console.Clear();
            Console.WriteLine("Welcome " + playerName + "!!!...Now, we must get you ready by making sure you have the perfect hair and dress!");

            

            

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
                         //contHairColor = HairColor.;
                   
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

            Console.WriteLine("\nYou look amazing!!!!\nYour contestant features are:\n");
            Console.WriteLine(c1);

            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\nLOOK!  YOUR COMPETITION JUST WALKED IN!!");

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
            Console.WriteLine("She looks like a strong competitor!!\n");
            Console.WriteLine(o1);

            Console.ReadLine();
            Console.Clear();
        



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + playerName + " Are you nervous, Yes or No?");

            string userAnswer = Console.ReadLine().ToUpper();

            switch (userAnswer)
            {
                case "Y":
                case "YES":
                    Console.WriteLine("\n{0}, don't be nervous!  You've got this!", playerName);
                    break;
                case "N":
                case "NO":
                    Console.WriteLine("\nGood for you!  I'm proud of your confidence!");
                    break;
                default:
                    Console.WriteLine("\nWell, you must be so nervous you cant even type yes or no!  That's ok!  I believe in you!");
                    break;
            }

            Console.ReadLine();
            Console.Clear();





            Console.ResetColor();

            //TODO: introduce 3 judges:
            //Create like 10 judges

            Console.WriteLine("Now lets meet our 3 judges!");

            #region JUDGES


            Judges j1 = new Judges();
            
            j1.Name = "Loretta";
            j1.Description = "A 65 year old lady from Nebraska that loves cats.";

            Judges j2 = new Judges("Tom", "A hair dresser from Texas.");
            Judges j3 = new Judges("Mary", "A kindergarten teacher from Missouri");
            Judges j4 = new Judges("Betty Sue", "Miss Buttercream Fair 1989");
            Judges j5 = new Judges("Randolph", "An artist from New York");

            Judges[] currentJudges = { j1, j2, j3, j4, j5 };
            //Randomly select the opponents hair color

            Random rand5 = new Random();
            int randomJudge = rand.Next(currentJudges.Length);

            Judges judges = currentJudges[randomJudge];

            Console.WriteLine();

            #endregion

            //FIX why it gives The same jusge every time
            string judge1 = judges.ToString();
            Console.WriteLine("Here is the first judge, " + judge1);
            
            
            Thread.Sleep(500);
            string judge2 = judges.ToString();
            Console.WriteLine("Here is the second judge, " + judge2);
            

           
            Thread.Sleep(125);

            Console.WriteLine("Here is the third judge, is " + judges.ToString());

            //TODO have them compete in beauty: Having them get 4 moves: walk, turn, pose, wave, smile, pivot turn, 
            //use Beeps to play a tune.
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("NEXT UP: " + playerName + "!!!!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(playerName + ", it's your turn to shine!!  Hit the stage and show them what you got!\n" +
                "Show them your best moves!");

            #region MUSIC
            int C = 264;
            int D = 297;
            int E = 330;
            int F = 352;
            int G = 396;
            int A = 440;
            int Bb = 466;
            int B = 495;
            int C2 = 528;

            // Now, we need to set the tempo for a note, half note, quarter note, and eighth note.
            int note = 1000;
            int half = 1000 / 2;
            int quarter = 1000 / 4;
            int eighth = 1000 / 8;

            // Now we can already "sing" a scale to warm up:
           
            Thread.Sleep(100);
            Console.Beep(C, quarter);
            Console.Beep(A, eighth);
            Console.Beep(D, quarter);
            Console.Beep(B, eighth);
            Console.Beep(E, quarter);
            Console.Beep(C, eighth);
            Console.Beep(F, quarter);
            Console.Beep(D, eighth);
            Console.Beep(G, quarter);
            Console.Beep(E, eighth);
            Console.Beep(A, quarter);
            Console.Beep(F, eighth);
            Console.Beep(B, quarter);
            Console.Beep(G, eighth);
            Console.Beep(C2, half);
            
            Console.Beep(C2, quarter);
            Console.Beep(B, quarter);
            Console.Beep(A, quarter);
            Console.Beep(G, quarter);
            Console.Beep(F, quarter);
            Console.Beep(E, quarter);
            Console.Beep(D, quarter);
            Console.Beep(C, half);
            #endregion

            #region MUSIC AGAIN

            #endregion
            Console.Clear();
            Console.WriteLine("\n\nGreat job " + playerName + " You just rocked that stage!!!\n\nLet's see what the judges thought!");
            Console.ReadLine();
            Console.Clear();






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


            //TODO SCORING

            #region SCORE

            int RandomNumber(int min, int max)
            {
                Random randomScore = new Random();
                return randomScore.Next(3, 10);
            }



                Score j1s = new Score();
                j1s.HairColorScore = RandomNumber(5,10);
            Thread.Sleep(125);
            j1s.HairStyleScore = RandomNumber(5, 10);
            Thread.Sleep(125);
            j1s.DressColorScore = RandomNumber(5, 10);
            Thread.Sleep(125);
            j1s.DressStyleScore = RandomNumber(5, 10);
            Thread.Sleep(125);
            j1s.SparkleScore = RandomNumber(7, 10);
            j1s.TotalScore = (j1s.HairColorScore + j1s.HairStyleScore + j1s.DressColorScore + j1s.DressStyleScore + j1s.SparkleScore);


                Score j2s = new Score();
                    j2s.HairColorScore = RandomNumber(5, 10);
                Thread.Sleep(125);
                j2s.HairStyleScore = RandomNumber(5, 10);
                Thread.Sleep(125);
                j2s.DressColorScore = RandomNumber(5, 10);
                Thread.Sleep(125);
                j2s.DressStyleScore = RandomNumber(5, 10);
                Thread.Sleep(125);
                j2s.SparkleScore = RandomNumber(5, 10);
            j2s.TotalScore = (j2s.HairColorScore + j2s.HairStyleScore + j2s.DressColorScore + j2s.DressStyleScore + j2s.SparkleScore);

                Score j3s = new Score();
            j3s.HairColorScore = RandomNumber(5, 10);
            Thread.Sleep(125);
            j3s.HairStyleScore = RandomNumber(5, 10);
            Thread.Sleep(125);
            j3s.DressColorScore = RandomNumber(5, 10);
            Thread.Sleep(125);
            j3s.DressStyleScore = RandomNumber(5, 10);
            Thread.Sleep(125);
            j3s.SparkleScore = RandomNumber(5, 10);
            j3s.TotalScore = (j3s.HairColorScore + j3s.HairStyleScore + j3s.DressColorScore + j3s.DressStyleScore + j3s.SparkleScore);

                int totalSparkle = j1s.SparkleScore + j2s.SparkleScore + j3s.SparkleScore;
          



            #endregion



            Console.ForegroundColor = ConsoleColor.Magenta;
            
            Console.WriteLine("Here is your score from Judge 1:");
            Console.WriteLine(j1s);
            Console.WriteLine("Your total score from judge 1 is: " + j1s.TotalScore);
            Console.ReadLine();
            Console.WriteLine("\nNext from Judge 2:");
            Console.WriteLine(j2s);
            Console.WriteLine("Your total score from judge 1 is: " + j2s.TotalScore);
            Console.ReadLine();
            Console.WriteLine("\nand finally from Judge 3:");
            Console.WriteLine(j3s);
            Console.WriteLine("Your total score from judge 1 is: " + j2s.TotalScore);
            Console.ReadLine();

            //FIGURE OUT WHY ITS NOT ADDING THE SCORES CORRECTLY
            Console.ForegroundColor = ConsoleColor.Cyan;
            int finalScore = j1s.TotalScore + j2s.TotalScore + j3s.TotalScore;
            
            

            Console.WriteLine("\n\nYour total score is " + finalScore + " out of a possible 150 points." );
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nWOW!  Great Job " + playerName + " That is a fantastic score!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Now lets see what your competition got\n");

            //GIVE OPPONENT A SCORE

            //COMPARE SCORE, do if statement, IF player score is gereat than opponent you win, if less you lose and if tie go into tie breaker round.
            Console.ForegroundColor = ConsoleColor.Red;
            #region OPPONENT SCORE

            int RandomJudgeNumber(int min, int max)
            {
                Random randomScore = new Random();
                return randomScore.Next(10, 25);
            }

            //need it to be random out of 1-30 each
            Score o1s = new Score();
            o1s.HairColorScore = RandomJudgeNumber(10,25);
            Thread.Sleep(125);
            o1s.HairStyleScore = RandomJudgeNumber(10, 25);
            Thread.Sleep(125);
            o1s.DressColorScore = RandomJudgeNumber(10, 25);
            Thread.Sleep(125);
            o1s.DressStyleScore = RandomJudgeNumber(10, 25);
            Thread.Sleep(125);
            o1s.SparkleScore = RandomJudgeNumber(10, 25);
            o1s.TotalScore = (o1s.HairColorScore + o1s.HairStyleScore + o1s.DressColorScore + o1s.DressStyleScore + o1s.SparkleScore);

           


            //Console.WriteLine("\nOut of a total for 30 points per category, her score is\n{0} for her hair color\n" +
            //    "{1} for her hair style\n{2} for her dress color\n{3} for her dress style\n which is a grand total of {4} score out" +
            //    "of 150, );

            Console.WriteLine("These scores are from all 3 judges combined (each category is 10 points from each judge)\n" +
                "That means each category is out of a possible 30\n\n" + o1s);

            Console.WriteLine("That is a total score of {0} out of 150", o1s.TotalScore);
            #endregion

            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("AND THE WINNER OF THE PRELIM PAGEANT IS......(drumroll please)...");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (finalScore > o1s.TotalScore)
            {
                Console.WriteLine("\n\n" + playerName + "!!!!!!");
                Console.WriteLine("CONGRATS!!!!!\nNow that you have won the prelim its time to get you ready for the State Pageant" +
                    "\nYou are one step closer to that National Crown!!!!");
            }
            else if (finalScore < o1s.TotalScore)
            {
                Console.WriteLine("Oh shoot, " + playerName + ", you didnt win this time but keep practicing and\n I know you will soon win that crown!");
                
                    
            }
            else if (finalScore == o1s.TotalScore)
            {
                Console.WriteLine("A tie!!!\n\nThe way a tie is broken is by comparing just the category of SPARKLE POINTS.\n" +
                    "The contesant with the most sparkle points wins!\n(Remember, each of teh 3 judges gave you sparkle points out of a possible 10" +
                    "points)\nThat means 30 points is a perfect SPARKLE SCORE...");

                Console.WriteLine("\n\nYour Sparkle points is {0} out of 30",totalSparkle);
                Console.WriteLine("Your opponents total Sparke points is {0} out of 30",o1s.SparkleScore);
                Console.ReadLine();
                Console.Clear();

                if (totalSparkle > o1s.SparkleScore)
                {
                    Console.WriteLine("\n\nCONGRATS " + playerName + "!!!!!!   YOU WON THE TIE BREAKER!\n" +
                        "You won the Pelim!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You now get to move onto the State Pageant!  We have alot of work to do!");
                }
                else if (totalSparkle < o1s.SparkleScore)
                {
                    Console.WriteLine("Oh shoot, " + playerName + ", you didnt win this time but keep practicing and I know you will soon win that crown!");
                }

                else
                {
                    Console.WriteLine("Another tie!?\nWow you two are such close competitors!");
                    //Break this tie??
                }
                //ties are broken by sparkle points. DONE
            }
            {

            }





        }//end Main()
    }//end Class
}//end Namespace
