import java.util.Scanner;

// Write a program to count the number of words in given sentence.
// Use any non-letter character as word separator.

public class _05_CountAllWords {
	public static void main(String[] args) {
		// Getting user input
		System.out.print("Please enter some text: ");
		Scanner input = new Scanner(System.in);
		String text = input.nextLine();
		
		// Splitting the words and getting the words count
		String[] words = text.split("\\W+");
		int wordsCount = words.length;
		
		// Printing the result
		System.out.print("The count of words is: " + wordsCount);
	}
}