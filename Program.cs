using System;

namespace TimesTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //  use variables for anything that may be dynamic
            int columnLimit = 20;                                   //  number of vertical columns

            int rowLimit = 50;                                      //  number of horizontal rows

            int startNumber = 1;                                    //  this defines the number in the upper-left corner of the table, in this case, (1 x 1)

            int spacing = getSpacing((columnLimit * rowLimit));     /*  calls method 'getSpacing' (line 36) which returns the number of characters within
                                                                     *  the largest possible number for formatting                                              */

            //  for-loops run continuously while the condition is not yet met
            //  format of a for-loop is as follows:
            //  for(variable to count loop iterations ; condition to check before running the loop ; iterate counter variable at end of each iteration)     //  format of a for-loop
            //  for(     int variableName = 0         ;              variableName < 10             ;               variableName++                     )     //  example, loop will run 10 times (0, 1, 2, 3, 4, 5, 6, 7, 8, 9)
            //  {
            //        Console.WriteLine("text goes here and will print " + variableName /* variable showing which iteration you are on */ + " times.");
            //  }

            //  This particular For-Loop starts at startNumber (top left corner will be (startNumber * startNumber)) and will print the appropriate number for each column for each row

            for (int rowNumber = startNumber; rowNumber <= rowLimit; rowNumber++)    //  this for-loop will run for-each row
            {
                Console.Write("| ");
                for(int columnNumber = startNumber; columnNumber <= columnLimit; columnNumber++)    //  this for-loop will run for-each column within each row and is called a 'Nested Loop' (loop-within-a-loop)
                {
                    int currentNumberCharacters = getSpacing(rowNumber * columnNumber); //  get the number of characters within the largest number possible, (rowNumber * columnNumber)
                    String textVersionOfNumber = (columnNumber * rowNumber).ToString(); //  take the largest number possible (rowNumber * columnNumber), convert it to a text string

                    //  this loop adds a space before the string version and then checks if the new length is equal to the pre-set formatting length, if not, loop again
                    for(int loopCounter = currentNumberCharacters; loopCounter < spacing; loopCounter++)
                    {
                        textVersionOfNumber = (" " + textVersionOfNumber);
                    }

                    //  add the straight brace for prettier formatting
                    Console.Write(textVersionOfNumber  + " | ");

                }   //  for-each loop for columns here

                Console.WriteLine();    //  new line after each row completes

            }   //  for-each loop for rows end here

            Console.Read(); //  wait for input before application closes
        }

        static int getSpacing(int highestNumber)
        {
            return highestNumber.ToString().Length;
        }
    }
}