import java.util.ArrayList;
import java.util.Scanner;

// Write a program that enters an array of strings and finds in it the largest sequence of equal elements.
// If several sequences have the same longest length, print the leftmost of them.
// The input strings are given as a single line, separated by a space.

public class _03_LargestSequenceOfEqualStrings {
	public static void main(String[] args) {
		// Getting user input
		String[] stringsArray;
		System.out.print("Please enter some words: ");
		Scanner input = new Scanner(System.in);
		String line = input.nextLine();
		
		// Splitting the values to an array
		stringsArray = line.split(" ");
		
		// Initializing variables
		ArrayList<String> currentSequence = new ArrayList<String>();
		ArrayList<String> bestSequence = new ArrayList<String>();
		bestSequence.add(stringsArray[0]);
		int currentLongest = 0;
		int bestLongest = 0;
		
		// Setting the current first element for comparison
		for (int index = 0; index < stringsArray.length; index++) {
			// Adding the current first element to the temporary array
			currentSequence.add(stringsArray[index]);
			
			// Searching through the array
			for (int search = index + 1; search < stringsArray.length; search++) {
				// If current first element equals the next, incrementing the temporary counter 
				// and adding to the temporary array list
				if (stringsArray[index].equals(stringsArray[search])) {
					currentLongest++;
					currentSequence.add(stringsArray[index]);
				}
				// If next element is not the same, no need to continue, so break
				else {
					break;
				}
			}
			
			// Checking if the temporary sequence is better than the previously better one
			if (bestLongest < currentLongest) {
				bestLongest = currentLongest;
				bestSequence = new ArrayList<String>(currentSequence);
			}
			
			// Reseting temporary variables
			currentLongest = 0;
			currentSequence.clear();
		}
		
		// Printing the result
		for (String string : bestSequence) {
			System.out.print(string + " ");
		}
	}
}