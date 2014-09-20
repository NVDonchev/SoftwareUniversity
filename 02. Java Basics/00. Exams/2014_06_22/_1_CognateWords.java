import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _1_CognateWords {
	public static void main(String[] args) {
		// Getting user input
		Scanner scan = new Scanner(System.in);
		String text = scan.nextLine();

		// Preparing a regular expression word matcher
		Pattern wordMatcher = Pattern.compile("\\w+");
		Matcher matcher = wordMatcher.matcher(text);
		ArrayList<String> words = new ArrayList<String>();

		// Finding the matches and adding them to a array list
		while (matcher.find()) {
			words.add(matcher.group(0));
		}
		
		ArrayList<String> cognatedResults = new ArrayList<String>();
		for (int firstPart = 0; firstPart < words.size(); firstPart++) {
			for (int secondPart = 0; secondPart < words.size(); secondPart++) {
				if (firstPart == secondPart) {
					continue;
				}
				
				String congatedWord = words.get(firstPart) + words.get(secondPart);
				
				for (int search = 0; search < words.size(); search++) {
					String cognatedString = words.get(firstPart) + "|" + words.get(secondPart) + "=" + congatedWord;
					if (congatedWord.equals(words.get(search)) && !cognatedResults.contains(cognatedString)) {
						cognatedResults.add(cognatedString);
					}
				}
			}
		}
		
		if (cognatedResults.size() > 0) {
			for (String result : cognatedResults) {
				System.out.println(result);
			}
		}
		else {
			System.out.println("No");
		}
	}
}