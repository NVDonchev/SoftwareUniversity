import java.util.ArrayList;
import java.util.Scanner;

// Write a program to find all increasing Sequences inside an array of integers.
// The integers are given in a single line, separated by a space.
// Print the Sequences in the order of their appearance in the input array,
// each at a single line. Separate the Sequence elements by a space.
// Find also the longest increasing Sequence and print it at the last line.
// If several Sequences have the same longest length, print the leftmost of them.

public class _04_LongestIncreasingSequence {
	public static void main(String[] args) {
		// Getting user input
		String[] numbersAsStrings;
		System.out.print("Please enter some integers: ");
		Scanner input = new Scanner(System.in);
		String line = input.nextLine();
		
		// Splitting the values to an array
		numbersAsStrings = line.split(" ");
		
		// Converting from string array to integer array
	    int[] numbers = new int[numbersAsStrings.length];
	    for (int index=0; index < numbersAsStrings.length; index++) {
	    	numbers[index] = Integer.parseInt(numbersAsStrings[index]);
	    }
		
		// Initializing variables
		ArrayList<String> sequences = new ArrayList<String>();
		int startIndex = 0;
		int endIndex = 1;
		int bestLength = 0;
		int bestSeqIndex = 0;
		
		// Looping through the numbers
		String tempSeqHolder = "";
		for (int index = 1; index < numbers.length; index++) {
			
			// If the number at current index is larger than the number in the previous index,
			// set the start
			if (numbers[index - 1] < numbers[index]) {
				
				endIndex = index + 1;
			}
			// If it's not, than it's time to start a new sequence
			if (numbers[index - 1] >= numbers[index] || index == numbers.length - 1) {
				
				// Add the previous sequence to an array list
				tempSeqHolder = "";
				for (int copyIndex = startIndex; copyIndex < endIndex; copyIndex++) {
					tempSeqHolder += numbersAsStrings[copyIndex] + " ";
				}
				sequences.add(tempSeqHolder);
				
				// Get the best sequence index
				if (bestLength < endIndex - startIndex) {
					bestLength = endIndex - startIndex;
					bestSeqIndex = sequences.size() - 1;
				}
				
				// Adjust the start index and the end index
				startIndex = index;
				endIndex = index + 1;
			}
		}
		
		// Printing the result
		for (String seq : sequences) {
			System.out.println(seq);
		}
		System.out.println("Longest: " + sequences.get(bestSeqIndex));
	}
}