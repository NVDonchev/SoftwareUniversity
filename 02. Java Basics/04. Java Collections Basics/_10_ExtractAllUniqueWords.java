import java.awt.font.ImageGraphicAttribute;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.HashSet;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

// At the first line at the console you are given a piece of text.
// Extract all words from it and print them in alphabetical order.
// Consider each non-letter character as word separator. Take the repeating
// words only once. Ignore the character casing. Print the result
// words in a single line, separated by spaces.

public class _10_ExtractAllUniqueWords {
	public static void main(String[] args) {
		// Getting user input
		Scanner scan = new Scanner(System.in);
		System.out.println("Please enter the first list of chars: ");
		String text = scan.nextLine();

		// Preparing a regular expression word matcher
		Pattern wordMatcher = Pattern.compile("\\w+");
		Matcher matcher = wordMatcher.matcher(text);
		ArrayList<String> words = new ArrayList<String>();

		// Finding the matches and adding them to a array list
		while (matcher.find()) {
			words.add(matcher.group(0).toLowerCase());
		}
		
		// Removing duplicates by casting to HashSet
		HashSet hashSet = new HashSet();
		hashSet.addAll(words);
		words.clear();
		words.addAll(hashSet);
		
		// Casting to an array and sorting it
		String[] wordsArray = new String[words.size()];
		wordsArray = words.toArray(wordsArray);
		Arrays.sort(wordsArray);
		
		// Printing the result
		for (String word : wordsArray) {
			System.out.println(word);
		}
	}
}