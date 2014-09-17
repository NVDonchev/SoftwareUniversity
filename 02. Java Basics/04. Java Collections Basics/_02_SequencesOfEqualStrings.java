import java.util.Scanner;

// Write a program that enters an array of strings and finds in it all sequences of equal elements.
// The input strings are given as a single line, separated by a space.

public class _02_SequencesOfEqualStrings {
	public static void main(String[] args) {
		// Getting user input
		String[] stringsArray;
		System.out.print("Please enter some words: ");
		Scanner input = new Scanner(System.in);
		String line = input.nextLine();
		
		// Splitting the values to an array
		stringsArray = line.split(" ");
		
		// Printing the result
		System.out.println("The resulting strings are:");
		System.out.print(stringsArray[0] + " ");
		for (int index = 1; index < stringsArray.length; index++) {
			if (!stringsArray[index].equals(stringsArray[index - 1])) {
				System.out.println();
			}

			System.out.print(stringsArray[index] + " ");
		}
	}
}