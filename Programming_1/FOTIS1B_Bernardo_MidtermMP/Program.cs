using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOTIS1B_Bernardo_MidtermMP
{
    class Program
    {
        static void Main(string[] args)

        /* In what year was DOTA 2 released?
        a. 2009
        b. 2010
        c. 2012
        d. 2013*

        Which game developing company developed DOTA 2? 
        a. Bethesda
        b. Valve Corporation*
        c. Rockstar Games
        d. Naughty Dog Inc

        Who is the latest hero released in DOTA 2 to this date (October 2021)?
        a. Dawnbreaker*
        b. Hoodwink
        c. Void Spirit
        d. Snapfire

        Known as the strongest neutral creep in DOTA2 that drops Aegis of Immortal, which lets you revive upon death.
        a. Granite Golem
        b. Roshan*
        c. Black Dragon
        d. Thunderhide

        Which is the most expensive item to build in DOTA 2?
        a. Divine Rapier
        b. Eye of Skadi
        c. Dagon Level 5*
        d. Radiance */
        {
            int points = 0;

            Console.Write("Welcome fellow DOTA2 player, care to test your skills? Choose the letter of the correct answer.");
            Console.WriteLine("\n\n1.) In what year was DOTA 2 released?" +
                "\na. 2009" +
                "\nb. 2010" +
                "\nc. 2012" +
                "\nd. 2013*");

            string answerQ1;
            Console.Write("Answer: ");
            answerQ1 = Console.ReadLine();
            if (answerQ1 == "A" || answerQ1 == "a")
            {
                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else if (answerQ1 == "B" || answerQ1 == "b")
            {
                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else if (answerQ1 == "C" || answerQ1 == "c")
            {
                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else if (answerQ1 == "D" || answerQ1 == "d")
            {
                points = points + 20;
                Console.Write("Congrats, you were right!\nCurrent Score:" + points);
            }
            else
            {
                Console.Write("Next time select choices carefully.\nCurrent Score:" + points);
            }

            Console.WriteLine("\n\n2.) Which game developing company developed DOTA 2?" +
                  "\na. Bethesda" +
                  "\nb. Valve Coroporation*" +
                  "\nc. Rockstar Games" +
                  "\nd. Naughty Dog Inc");

            string answerQ2;
            Console.Write("Answer: ");
            answerQ2 = Console.ReadLine();
            if (answerQ2 == "A" || answerQ2 == "a")
            {
                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else if (answerQ2 == "B" || answerQ2 == "b")
            {
                points = points + 20;
                Console.Write("Congrats, you were right!\nCurrent Score:" + points);
            }
            else if (answerQ2 == "C" || answerQ2 == "c")
            {
                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else if (answerQ2 == "D" || answerQ2 == "d")
            {
                
                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else
            {
                Console.Write("Next time select choices carefully.\nCurrent Score:" + points);
            }

            Console.WriteLine("\n\n3.) Who is the latest hero released in DOTA 2 to this date(October 2021)?" +
                  "\na. Dawnbreaker*" +
                  "\nb. Hoodwink" +
                  "\nc. Void Spirit" +
                  "\nd. Snap Fire");

            string answerQ3;
            Console.Write("Answer: ");
            answerQ3 = Console.ReadLine();
            if (answerQ3 == "A" || answerQ3 == "a")
            {
                points = points + 20;
                Console.Write("Congrats, you were right!\nCurrent Score:" + points);
            }
            else if (answerQ3 == "B" || answerQ3 == "b")
            {
                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else if (answerQ3 == "C" || answerQ3 == "c")
            {
                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else if (answerQ3 == "D" || answerQ3 == "d")
            {

                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else
            {
                Console.Write("Next time select choices carefully.\nCurrent Score:" + points);
            }

            Console.WriteLine("\n\n4.) Known as the strongest neutral creep in DOTA2 that drops the Aegis of Immortal, which lets you revive upon death." +
                 "\na. Granite Golem" +
                 "\nb. Roshan*" +
                 "\nc. Black Dragon" +
                 "\nd. Thunderhide");

            string answerQ4;
            Console.Write("Answer: ");
            answerQ4 = Console.ReadLine();
            if (answerQ4 == "A" || answerQ4 == "a")
            {
                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else if (answerQ4 == "B" || answerQ4 == "b")
            {
                points = points + 20;
                Console.Write("Congrats, you were right!\nCurrent Score:" + points);
            }
            else if (answerQ4 == "C" || answerQ4 == "c")
            {
                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else if (answerQ4 == "D" || answerQ4 == "d")
            {

                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else
            {
                Console.Write("Next time select choices carefully.\nCurrent Score:" + points);
            }

            Console.WriteLine("\n\n5.) Which is the most expensive item to build in DOTA 2?" +
                 "\na. Divine Rapier" +
                 "\nb. Eye of Skadi" +
                 "\nc. Dagon Level 5*" +
                 "\nd. Radiance");

            string answerQ5;
            Console.Write("Answer: ");
            answerQ5 = Console.ReadLine();
            if (answerQ5 == "A" || answerQ5 == "a")
            {
                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else if (answerQ5 == "B" || answerQ5 == "b")
            {
                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else if (answerQ5 == "C" || answerQ5 == "c")
            {
                points = points + 20;
                Console.Write("Congrats, you were right!\nCurrent Score:" + points);
            }
            else if (answerQ5 == "D" || answerQ5 == "d")
            {

                Console.Write("That was not the correct answer.\nCurrent Score:" + points);
            }
            else
            {
                Console.Write("Next time select choices carefully.\nCurrent Score:" + points);
            }

            Console.Clear();
            Console.WriteLine("Your total score is\t"+ points +"\tout of 100");





            Console.ReadKey();
            }
                }
            }
        
    

