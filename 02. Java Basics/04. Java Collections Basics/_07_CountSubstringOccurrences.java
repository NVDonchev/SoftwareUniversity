import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

// Write a program to find how many times given string appears in given text as substring.
// The text is given at the first input line. The search string is given at the second
// input line. The output is an integer number. Please ignore the character casing. 

public class _07_CountSubstringOccurrences {
	public static void main(String[] args) {
		// Getting user input in lower case
		System.out.println("Please enter some text: ");
		Scanner input = new Scanner(System.in);
		String text = input.nextLine().toLowerCase();
		System.out.print("\nPlease enter characters to search for: ");
		String chars = input.nextLine().toLowerCase();
		
		// Searching for the chars appearance and counting it
		int index = text.indexOf(chars);
		int count = 0;
		while (index != -1) {
		    count++;
		    text = text.substring(index + 1);
		    index = text.indexOf(chars);
		}
		
		// Printing the result
		System.out.print("\nThe count of chars appearanse is: " + count);
	}
}