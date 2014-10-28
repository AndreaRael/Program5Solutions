using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            int myAgeDoubled = DoubleIt(27);
            Console.WriteLine(DoubleIt(myAgeDoubled));

            //keep the console open
            Console.ReadKey();
        }
        /// <summary>
        /// Writes "hello world" to the console
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="someNumber"></param>
        /// <returns></returns>
        static int DoubleIt(int someNumber)
        {
            //code here
            return someNumber * 2;
        }
        /// <summary>
        /// Prints numbers to the console from start to end
        /// </summary>
        /// <param name="startNumber">number the loop starts at</param>
        /// <param name="endNumber">inclusive end point of the loop</param>
        static void LoopSomeNumbers(int startNumber, int endNumber)
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static void LoopTests()
        {
            LoopSomeNumbers(5,10);
            LoopSomeNumbers(863428, 879835);
            LoopSomeNumbers(27, DoubleIt(27));
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        static int VowelCounter3000(string inputString)
        {
            //declare a counter for the vowels
            int numberOfVowelsFound = 0; 

            //loop over each letter of the string
            for (int if = 0; i < inputString.Length; i = i + 1)
            {
                //take a letter from the string 
                //and make it lowercase
                string letter = inputString[i].ToString().ToLower;
    
                if(letter == "a" || letter = "e" || letter = "i" || letter = "o" || letter = "u");
                {
                //found a vowel. huzzah!
                    numberOfVowelsFound = numberOfVowelsFound + 1;
                } // Closes if loop
                //alternate way of checking to see if it's a vowel
                if("aeiou".Contains(letter))
                { 
                        //Usuually I would inriment numberOfVowels here!
                }
           } // Closes for loop
            
            //loop complete, time to write the output
            Console.WriteLine(inputString + " has " + numberOfVowelsFound + " vowels in it");
            
            return numberOfVowelsFound;
        } // End of VowlCounter3000 Function
    
        /// <summary>
        /// 
        /// </summary>
        static void VowelCounter3000Tests()
        {
            //count the number of vowels counted
            int totalNumberOfVowelsCounted = 0;
            totalNumberOfVowelsCounted += VowelsCounted ("Jackie seems like a guy who might like Nickelback");
            totalNumberOfVowelsCounted += VowelsCounted ("I like to eat sushi");
            Console.WriteLine ("total Vowels Counted: " + totalNumberOfVowelsCounted);
         }
    
    } // End of class
} // End of Namespace
