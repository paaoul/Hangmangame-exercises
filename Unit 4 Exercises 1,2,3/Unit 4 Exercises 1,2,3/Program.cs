namespace Unit_4_Exercises_1_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Array holds 10 zip codes for delivery company. Prompt for zipcode, tell if it is in the system.
            //int[] zipCodes = new int[10] { 11111, 11112, 11113, 11114, 11115, 11116, 11117, 11118, 11119, 11110};
            //Console.WriteLine("What is the zipcode of the customer?");
            //int customerZip = int.Parse(Console.ReadLine());
            //bool match = false;

            //for (int i = 0; i < 9; i++)
            //{
            //    if (customerZip == zipCodes[i])
            //    {
            //        match = true;
            //    }
            //}

            //if (match == true)
            //{
            //    Console.WriteLine("The entered zipcode is valid for delivery");
            //}
            //else
            //{
            //    Console.WriteLine("The entered zipcode is not valid for delivery");
            //}


            ////Ask teacher to enter in their name and final score for their class. Print highest grade and the average grade
            //Console.WriteLine("How many students do you have in your class?");
            //int x = int.Parse(Console.ReadLine());
            //string[] studentNames = new string[x];
            //double[] studentGrade = new double[x];
            //double total = 0;
            //double highest = 0;

            //for (int i = 0; i < studentNames.Length; i++)
            //{
            //    Console.WriteLine("What is the #{0} student's name?", i + 1); 
            //    studentNames[i] = Console.ReadLine();
            //    Console.WriteLine("What is the #{0} student's grade?", i + 1);
            //    studentGrade[i] = double.Parse(Console.ReadLine());
            //    total += studentGrade[i];

            //    if (studentGrade[i] > highest)
            //    {
            //        highest = studentGrade[i];
            //    }
            //}

            //double average = total / x;

            //Console.WriteLine("The highest grade in the class is {0}", highest);
            //Console.WriteLine("The average grade in the class is {0}", average);


            //Create a game similar to hangman. I had a lot of trouble with this one.....
            string[] words = new string[8] { "alphabet", "beauty", "carrot", "death", "earring", "finger", "gooch", "hum" };
            Random random = new Random();
            int randomIndex = random.Next(0, 8);
            string selectedWord = words[randomIndex];
            string hidden = "";
            int guessedWrong = 0;

            for (int i = 0; i < selectedWord.Length; i++)
            {
                hidden += "*";
            }

            while (hidden.Contains("*"))
            {
                if (guessedWrong <= 9)
                {
                    Console.WriteLine("Word is " + hidden);
                    Console.WriteLine("What letter would you like to guess?");
                    char guessed = char.Parse(Console.ReadLine());
                    bool containsLetter = false;
                    for (int i = 0; i < selectedWord.Length; i++)
                    {
                        if (selectedWord[i] == guessed)
                        {
                            hidden = hidden.Remove(i, 1);
                            hidden = hidden.Insert(i, guessed.ToString());
                            containsLetter = true;
                        }
                        
                    }
                    if (containsLetter == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Yes! {0} is in the word", guessed);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry {0} is not in the word", guessed);
                        guessedWrong++;
                    }
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }

            if (!hidden.Contains("*"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations you got the word! It was {0}", selectedWord);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have guessed incorrectly too many times. The correct word was {0}", selectedWord);
            }

            










        }
    }
}