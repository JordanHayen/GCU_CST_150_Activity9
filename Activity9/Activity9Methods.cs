using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9
{
    static class Activity9Methods
    {
        private static Random randomGenerator; // An object used to generate random numbers

        // A static constructor used to initialize the randomGenerator object. Made with help from Codecademy (n.d.).
        static Activity9Methods()
        {
            randomGenerator = new Random(); // Initializes the randomGenerator object
        }

        // This method adds two integers
        public static int IntegerSum(int integer1, int integer2)
        {
            return integer1 + integer2; // Returns the sum of the two parameters
        }

        // This method calculates the average of five doubles
        public static double Average(double term1, double term2, double term3, double term4, double term5)
        {
            return (term1 + term2 + term3 + term4 + term5) / 5; // Returns the result of adding the five parameters together and dividing them by five
        }

        // This method generates two random integers and adds them
        public static int RandomSum()
        {
            return randomGenerator.Next() + randomGenerator.Next(); // Uses the randomGenerator object to generate two random integers and returns the sum
        }

        // This method determines whether or not the sum of three integers can be evenly divided by three
        public static bool DivisibleBy3(int integer1, int integer2, int integer3)
        {
            return (integer1 + integer2 + integer3) % 3 == 0; // Returns the result of adding the three parameters, taking the remainder when divided by three, and using a logical comparison to determine whether or not that remainder is zero
        }

        // This method takes in two strings and returns the string with fewer characters
        public static string FewerCharacters(string string1, string string2)
        {
            if(string1.Length < string2.Length) // If the first parameter has a greater length than the second, the first parameter is returned
            {
                return string1; // Returns the first parameter
            } 
            else // Otherwise, the second parameter is returned
            {
                return string2; // Returns the second parameter
            }
        }

        // This method returns the greatest item in an array of doubles
        public static double GreatestInArray(double[] array)
        {
            double result = array[0]; // A variable that will contain the value to be returned. By default it is set to the first value in the parameter

            // This loop iterates over every item in the parameter array except for the first
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] > result) // If the current item in the array is greater than the result variable, the result variable is set to the current item
                {
                    result = array[i]; // The result variable is set to the current item in the array
                }
            }

            return result; // The result variable is returned
        }

        // This method generates an array of fifty random integers
        public static int[] GenerateIntegerArray()
        {
            int[] result = new int[50]; // An integer array with a length of fifty that will be returned

            // This loop iterates over every item in the result array
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = randomGenerator.Next(); // The current item in the result array is set to a random integer
            }

            return result; // The result array is returned
        }

        // This method returns true if two booleans are the same
        public static bool SameValue(bool bool1, bool bool2)
        {
            return bool1 == bool2; // Returns the result of comparing the parameters with the equality operator
        }

        // This method returns the result of multiplying an integer and a double
        public static double Product(int parameter1, double parameter2)
        {
            return parameter1 * parameter2; // Returns the result of multiplying the two parameters
        }

        // This method returns the average of every term in a two-dimensional array of integers. Made with help from the textbook (Gaddis, 317).
        public static double AverageOf2DArray(int[][] array)
        {
            int total = 0; // A variable to contain the total of terms in the array
            int terms = 0; // A variable to contain the number of terms in the array

            // This loop iterates over every item in the outer array
            for(int i = 0; i < array.Length; i++)
            {
                // This loop iterates over every item in the inner array
                for(int j = 0; j < array[i].Length; j++)
                {
                    total += array[i][j]; // The current item in the array is added to the total variable
                    terms++; // The terms variable is increased by one
                }
            }

            return (double)total / terms; // Returns the result of dividing the total variable by the terms variable. One of the variables must be cast into a double in case the result is not an integer
        }

    }
}

// Reference:
// Codecademy. (n.d.). Learn C#: Classes and Objects. Codecademy. https://www.codecademy.com/learn/learn-c-sharp/modules/learn-csharp-classes/cheatsheet
// Gaddis, T. (2020). Starting Out With Visual C#. Pearson.