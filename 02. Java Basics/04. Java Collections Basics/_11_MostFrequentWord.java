import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

// Write a program to find the most frequent word in a text and print it,
// as well as how many times it appears in format "word -> count".
// Consider any non-letter character as a word separator. Ignore the character casing.
// If several words have the same maximal frequency, print all of them in alphabetical order.

public class _11_MostFrequentWord {
	public static void main(String[] args) {
		// Getting user input
		Scanner scan = new Scanner(System.in);
		System.out.print("Please enter some text: ");
		String text = scan.nextLine();

		// Preparing a regular expression word matcher
		Pattern wordMatcher = Pattern.compile("\\w+");
		Matcher matcher = wordMatcher.matcher(text);
		ArrayList<String> words = new ArrayList<String>();

		// Finding the matches and adding them to a array list
		while (matcher.find()) {
			words.add(matcher.group(0).toLowerCase());
		}
		
		// Initializing a HashMap
		HashMap<String, Integer> wordsAndCounter = new HashMap<String, Integer>();

		// Looping through the words
		int mostFrequent = 0;
		for (int word = 0; word < words.size(); word++) {
			int wordFrequency = 0;
			for (int matchWord = word; matchWord < words.size(); matchWord++) {
				// If a match is found - increment the counter
				if (words.get(word).equals(words.get(matchWord))) {
					wordFrequency++;
					
					// If the matching word is not in the HashMap - add it
					if (!wordsAndCounter.containsKey(words.get(word))) {
						wordsAndCounter.put(words.get(word), wordFrequency);
					}
					// If it is in the HashMap - increment the match counter by one
					else if (wordsAndCounter.get(words.get(word)) < wordFrequency) {
						wordsAndCounter.put(words.get(word), wordsAndCounter.get(words.get(word)) + 1);
					}
					
					// Setting the most frequent counter
					if (mostFrequent < wordFrequency) {
						mostFrequent = wordFrequency;
					}
				}
			}
		}
		
		// Initializing a new array list and copying there only the most frequent words
		ArrayList<String> sortedWords = new ArrayList<String>();
		for (Map.Entry<String,Integer> entry : wordsAndCounter.entrySet()) {
			if (entry.getValue() == mostFrequent) {
				sortedWords.add(entry.getKey());
			}
		}
		
		// Sorting the array list of word
		Collections.sort(sortedWords);
		
		// Printing the result
		for (String word : sortedWords) {
			System.out.println(word + " -> " + mostFrequent + " times");
		}
	}
}