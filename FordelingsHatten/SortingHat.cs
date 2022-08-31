using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordelingsHatten
{
    internal class SortingHat
    {
        public SortingHat()
        {
            //Variables
            int dorm = 0;
            string dorms = "";
            string dormCharacteristics = "";
            string yesNo = "";
            bool sortingDone = false;

            //Creates a random generator
            Random rng = new Random();

            //A loop that runs till the user has said yes to be put in a dorm
            do
            {
                //Clears the console
                Console.Clear();
                //Asks if user is ready
                Console.WriteLine("Er du klar til at blive fordelt til et af hogwarts husene (y/n)");
                yesNo = Console.ReadLine().ToLower();

                //Checks the users answer
                if (yesNo == "y")
                {
                    //Put a random number form 0 to 3 in the dorm int
                    dorm = rng.Next(0, 4);

                    //Checks what dorm the number is
                    if (dorm == 0)
                    {
                        //Sets the dorms string to the dorms name
                        //Sets the bool sortingDone to true, so the program know the sorting is done
                        dorms = ((Dorms)0).ToString();
                        sortingDone = true;

                        //puts the the dorms characteristics in the string 
                        dormCharacteristics = "du er modig og stærk";
                    }
                    else if (dorm == 1)
                    {
                        //The same is done as above
                        dorms = ((Dorms)1).ToString();
                        sortingDone = true;
                        dormCharacteristics = "du er loyal og tapre";
                    }
                    else if (dorm == 2)
                    {
                        //The same is done as above
                        dorms = ((Dorms)2).ToString();
                        sortingDone = true;
                        dormCharacteristics = "du er vidbegærlig og intelligent";
                    }
                    else
                    {
                        //The same is done as above
                        dorms = ((Dorms)3).ToString();
                        sortingDone = true;
                        dormCharacteristics = "du er snedig, viljefast og som ikke skyr noget for at nå dit mål";
                    }

                    //Writes out in the console what dorm your in, and why.
                    Console.WriteLine("Du er en del af " + dorms + "\r\nFordi " + dormCharacteristics);
                }
                
            } while (sortingDone != true);
        }
    }
}
