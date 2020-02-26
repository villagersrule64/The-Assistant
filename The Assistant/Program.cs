using System;

namespace The_Assistant
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Code();
            }

            catch (Exception e)
            {
                Console.WriteLine("You have been caught, criminal!!");
                Console.WriteLine(e);
            }

            finally
            {
                Console.WriteLine("Prison has forced you to quit.");
                Console.ReadKey();
            }
        }
        static void Code()
        {
            Console.WriteLine("Hello! I am The Assistant.");
            for (; ; )
            {
                Console.WriteLine("Please type 'hello' to start!");
                string start = Console.ReadLine();
                if (start == "hello")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Oops, I don't think '{0}' is correct.", start);
                    continue;
                }
            }
            Random rnd = new Random();

            Console.WriteLine("Okay! Let's begin.");
            Console.WriteLine("What do you want to do today, umm...\nUmm...\nUmm...\nUmm...");

            Console.WriteLine("What was your name again?");

            string nameInput = Console.ReadLine();
            Console.WriteLine("Hmm... I don't think that's right.");

            Console.Write("Please do it again: ");
            string nameInput2 = Console.ReadLine();

            Console.WriteLine("So your name is {0}, right? Say 'yes' or 'no'.", nameInput);
            string nameCorrect = Console.ReadLine();
            string name = "";

            if (nameCorrect == "yes")
            {
                Console.WriteLine("Meh. I'll just call you {0}.", nameInput2);
                name = nameInput2;
            }
            else if (nameCorrect == "no")
            {
                Console.WriteLine("Hmm... I'll just call you {0}.", nameInput);
                name = nameInput;
            }
            else
            {
                Console.WriteLine("Never mind. You'll just be 'Guest'.");
                name = "Guest";
            }

            Console.WriteLine("So, {0}, I forgot what the year is.", name);
            var date = DateTime.UtcNow;
            int year = date.Year;
            Console.WriteLine("Could you please tell me?");
            Console.ReadLine();
            Console.WriteLine("Please tell the truth to me.");
            Console.ReadLine();
            Console.WriteLine("Oh yeah! It's {0}.", date.Year);

            Console.WriteLine("Thank you for telling me that data.");
            Console.WriteLine("How old are you, {0}? Now that I know the year, {1}, it's easy.", name, date.Year);

            string ageInput = Console.ReadLine();
            int age = Int32.Parse(ageInput);
            int randAge = Randomize(8, 20);
            for (; ; )
            {
                if (randAge == age)
                {
                    randAge = Randomize(10, 20);
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("I thought you were {0}, {1}. Not {2}.", randAge, name, age);
            Console.WriteLine("Okay fine, {0}. This time I'll listen to you.", name);
            Console.WriteLine("You are {0}, so you were born in...", age);
            Console.Write(" Beep Bop!");
            randAge = Randomize(2, 8);
            Console.WriteLine(" Oh hello tiny robot! Tiny robot, meet {0}. He's {1}, so younger than you by {2}.", name, age, randAge);
            Console.WriteLine("Ok. Back to what we were doing. How old were you again?");
            Console.ReadKey();
            Console.Write("- Oh, you're {0}, {1}.", age, name);
            randAge = rnd.Next();
            Console.WriteLine(" That means you were born in {0}. Right?", year - age - randAge);
            Console.ReadLine();
            int yearBornInput = year - age;
            int yearBornInput2 = year - 1 - age;
            Console.WriteLine("Ok. You were born in {0} or {1}. Tell me 'left' or 'right'.", yearBornInput, yearBornInput2);
            for (; ; )
            {
                if (Console.ReadLine() == "left")
                {
                    Console.WriteLine("So you were born in {0}.", yearBornInput2);
                    Console.Write("Oops. Sorry.");
                    Console.WriteLine(" You were born in {0}, {1}. Processing...", yearBornInput, name);
                    int yearBorn = yearBornInput;
                    break;

                }
                else if (Console.ReadLine() == "right")
                {
                    Console.WriteLine("So you were born in {0}.", yearBornInput);
                    Console.Write("Oops. Sorry.");
                    Console.WriteLine(" You were born in {0}, {1}. Processing...", yearBornInput2, name);
                    int yearBorn = yearBornInput2;
                    break;

                }
                else
                {
                    Console.WriteLine("Please enter 'left' or 'right'.");
                    continue;
                }
            }

            Console.WriteLine("Processing complete!");
            Console.WriteLine("I'm learning a lot about you! Wait. I'm going away for a while.");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("Bleep Beep Beep! (Say 'Come back' until he comes back!)");

            int comebacks = 0;
            for (bool no = true; no; )
            {
                string message = Console.ReadLine();

                if (message == "Come back")
                {
                    comebacks++;
                    if (comebacks == 5)
                    {
                        Console.WriteLine("Fine. I'll come back.");
                        no = false;
                    }
                    else
                        Console.WriteLine("...");
                }
                else
                    Console.WriteLine("Booooooop. (Say 'Come back'!)");

            }
            Console.WriteLine("I think we should stop now. Say 'yes' or 'no'.");
            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("So you are choosing to continue and put up with my annoyingness?");
                if (Console.ReadLine() == "yes")
                {
                    Console.WriteLine("Let's continue.");

                }
                else if (Console.ReadLine() == "no")
                {
                    throw new Exception("error error error\nBYE!!!");
                }
                else
                {
                    Console.WriteLine("We'll just continue.");
                }
            } else if (Console.ReadLine() == "no")
            {
                throw new Exception("error error error\nBYE!!!");
            } else
            {
                Console.WriteLine("You are forced to continue!");
            }
            
            throw new Exception("The police found you before you were able to finish.");
        }

        public static int Randomize(int randMin, int randMax)
        {
            Random rnd = new Random();
            return rnd.Next(randMin, randMax);
        }
    }
}
