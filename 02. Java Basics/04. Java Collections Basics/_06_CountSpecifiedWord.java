import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

// Write a program to find how many times a word appears in given text.
// The text is given at the first input line. The target word is given
// at the second input line. The output is an integer number. Please ignore
// the character casing. Consider that any non-letter character is a word separator.

public class _06_CountSpecifiedWord {
	public static void main(String[] args) {
		// Getting user input in lower case
		System.out.println("Please enter some text: ");
		Scanner input = new Scanner(System.in);
		String text = input.nextLine().toLowerCase();
		System.out.print("\nPlease enter a word to search for: ");
		String word = input.nextLine().toLowerCase();
		
		// Setting a regular expression matcher
		Matcher m = Pattern.compile(word + "\\b").matcher(text);
		
		// Counting matches
		int matches = 0;
		while (m.find()) {
			matches++;
		}

		// Printing the result
		System.out.print("\nThe count of words is: " + matches);
	}
}