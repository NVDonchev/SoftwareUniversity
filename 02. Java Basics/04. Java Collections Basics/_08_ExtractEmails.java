import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

// Write a program to extract all email addresses from given text. The text comes at the first input line.
// Print the emails in the output, each at a separate line. Emails are considered to be in format <user>@<host>

public class _08_ExtractEmails {
	public static void main(String[] args) {
		// Getting user input in lower case
		System.out.print("Please enter some text: ");
		Scanner input = new Scanner(System.in);
		String text = input.nextLine().toLowerCase();
		
		// Preparing a regular expression email matcher
		Pattern emailMatcher = Pattern.compile("\\S+@\\w+(\\.\\w+)+");
		Matcher matcher = emailMatcher.matcher(text);
		ArrayList<String> emails = new ArrayList<String>();
		
		// Finding the matches and adding them to a array list
		while (matcher.find()) {
			emails.add(matcher.group(0));
	    }
		
		// Printing the result
		System.out.println("The email/s:");
		for (String email : emails) {
			System.out.println(email);
		}
	}
}