import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

// We are given a sequence of N playing cards from a standard deck. The input consists of
// several cards (face + suit), separated by a space. Write a program to calculate and print
// at the console the frequency of each card face in format "card_face -> frequency".
// The frequency is calculated by the formula appearances / N and is expressed in percentages
// with exactly 2 digits after the decimal point. The card faces with their frequency should be
// printed in the order of the card face's first appearance in the input. The same card can appear
// multiple times in the input, but it's face should be listed only once in the output.

public class _12_CardsFrequencies {
	public static void main(String[] args) {
		// Getting user input
		Scanner scan = new Scanner(System.in);
		System.out.print("Please enter some text: ");
		String text = scan.nextLine();

		// Preparing a regular expression card faces matcher
		Pattern cardFacesMatcher = Pattern.compile("\\w+");
		Matcher matcher = cardFacesMatcher.matcher(text);
		ArrayList<String> cardFaces = new ArrayList<String>();

		// Finding the matches and adding them to a array list
		while (matcher.find()) {
			cardFaces.add(matcher.group(0));
		}

		// Initializing a LinkedHashMap - it keeps the add order of the elements
		LinkedHashMap<String, Integer> cardFacesAndCounter = new LinkedHashMap<String, Integer>();
		
		// Looping through the card faces
		int mostFrequent = 0;
		for (int face = 0; face < cardFaces.size(); face++) {
			int faceFrequency = 0;
			for (int matchFace = face; matchFace < cardFaces.size(); matchFace++) {
				// If a match is found - increment the counter
				if (cardFaces.get(face).equals(cardFaces.get(matchFace))) {
					faceFrequency++;

					// If the matching word is not in the HashMap - add it
					if (!cardFacesAndCounter.containsKey(cardFaces.get(face))) {
						cardFacesAndCounter.put(cardFaces.get(face), faceFrequency);
					}
					// If it is in the HashMap - increment the match counter by one
					else if (cardFacesAndCounter.get(cardFaces.get(face)) < faceFrequency) {
						cardFacesAndCounter.put(cardFaces.get(face),
								cardFacesAndCounter.get(cardFaces.get(face)) + 1);
					}
					
					// Setting the most frequent counter
					if (mostFrequent < faceFrequency) {
						mostFrequent = faceFrequency;
					}
				}
			}
		}
		
		// Calculating the percent of appearance and printing the result
		for (Map.Entry<String,Integer> entry : cardFacesAndCounter.entrySet()) {
			double percent = (double)entry.getValue() / cardFaces.size() * 100;
			System.out.printf("%s -> %.2f%%\n", entry.getKey(), percent);
		}
	}
}