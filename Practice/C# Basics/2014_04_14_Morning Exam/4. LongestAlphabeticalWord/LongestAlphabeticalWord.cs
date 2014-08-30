using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class LongestAlphabeticalWord
{
    static void Main()
    {
        string word = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string[,] square = new string[n, n];
        StringBuilder builder = new StringBuilder();
        List<string> sequences = new List<string>();
        int wordIndex = -1;

        // Constructing the square
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (wordIndex < word.Length - 1)
                {
                    wordIndex++;
                }
                else
                {
                    wordIndex = 0;
                }

                square[row, col] = word[wordIndex].ToString();
            }
        }

        // Searching
        // Generating starting point
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                // Preparing
                builder.Append(square[row, col]);
                int currLetterCol = col;
                int currLetterRow = row;

                // Searching to the right
                for (int nextLetterCol = col + 1; nextLetterCol < n; nextLetterCol++)
                {
                    // Checking if next letter is alphabetically after current letter
                    if (String.Compare(square[row, currLetterCol], square[row, nextLetterCol]) == -1)
                    {
                        builder.Append(square[row, nextLetterCol]);
                    }
                    else
                    {
                        break;
                    }

                    currLetterCol++;
                }

                // Searching to the left
                // Preparing
                sequences.Add(builder.ToString());
                builder.Clear();
                builder.Append(square[row, col]);
                currLetterCol = col;
                currLetterRow = row;

                for (int nextLetterCol = col - 1; nextLetterCol >= 0; nextLetterCol--)
                {
                    // Checking if next letter is alphabetically after current letter
                    if (String.Compare(square[row, currLetterCol], square[row, nextLetterCol]) == -1)
                    {
                        builder.Append(square[row, nextLetterCol]);
                    }
                    else
                    {
                        break;
                    }

                    currLetterCol--;
                }

                // Searching to the top
                // Preparing
                sequences.Add(builder.ToString());
                builder.Clear();
                builder.Append(square[row, col]); 
                currLetterCol = col;
                currLetterRow = row;

                for (int nextLetterRow = row - 1; nextLetterRow >= 0; nextLetterRow--)
                {
                    // Checking if next letter is alphabetically after current letter
                    if (String.Compare(square[currLetterRow, col], square[nextLetterRow, col]) == -1)
                    {
                        builder.Append(square[nextLetterRow, col]);
                    }
                    else
                    {
                        break;
                    }

                    currLetterRow--;
                }

                // Searching to the bottom
                // Preparing
                sequences.Add(builder.ToString());
                builder.Clear();
                builder.Append(square[row, col]);
                currLetterCol = col;
                currLetterRow = row;

                for (int nextLetterRow = row + 1; nextLetterRow < n; nextLetterRow++)
                {
                    // Checking if next letter is alphabetically after current letter
                    if (String.Compare(square[currLetterRow, col], square[nextLetterRow, col]) == -1)
                    {
                        builder.Append(square[nextLetterRow, col]);
                    }
                    else
                    {
                        break;
                    }

                    currLetterRow++;
                }

                sequences.Add(builder.ToString());
                builder.Clear();
            }
        }

        // Extract the longest sequence
        string result = sequences.OrderByDescending(x => x.Length).ThenBy(x => x).FirstOrDefault();

        // Print the result
        Console.WriteLine(result);
    }
}