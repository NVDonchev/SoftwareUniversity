import java.util.Scanner;

// Write a program to generate and print all 3-letter words
// consisting of given set of characters. For example if we
// have the characters 'a' and 'b', all possible words will be
// "aaa", "aab", "aba", "abb", "baa", "bab", "bba" and "bbb".
// The input characters are given as string at the first line
// of the input.Input characters are unique (there are no repeating characters).

public class _2_ThreeLetterWords {
	public static void main(String[] args) {
		// Getting user input
		System.out.print("Enter a string (the chars to be used): ");
		Scanner input = new Scanner(System.in);
		String inputStr = input.next();
		
		// Printing combinations
		System.out.print("The combinations are: ");
		for (int s1 = 0; s1 < inputStr.length(); s1++) {
			for (int s2 = 0; s2 < inputStr.length(); s2++) {
				for (int s3 = 0; s3 < inputStr.length(); s3++) {
					System.out.printf("%s%s%s ", inputStr.charAt(s1), inputStr.charAt(s2), inputStr.charAt(s3));
				}
			}
		}
	}
}