import java.util.ArrayList;
import java.util.Scanner;

// Write a program to generate and print all symmetric numbers
// in given range [start…end] (0 ≤ start ≤ end ≤ 999).
// A number is symmetric if its digits are symmetric toward
// its middle. For example, the numbers 101, 33, 989 and 5
// are symmetric, but 102, 34 and 997 are not symmetric.

public class _1_SymmetricNumbersInRange {
	public static void main(String[] args) {
		// Getting user input
		System.out.print("Please enter two integers a and b (a < b): ");
		Scanner input = new Scanner(System.in);
		int startNum = input.nextInt();
		int endNum = input.nextInt();
		
		// Iterating through the numbers
		ArrayList<String> symmetricNums = new ArrayList<>();
		for (int num = startNum; num <= endNum; num++) {
			
			boolean isSymmetric = true;
			String numAsString = Integer.toString(num);
			int numLength = numAsString.length();
			
			// Comparing digits
			for (int digit = 0; digit < numLength; digit++) {
				if (numAsString.charAt(digit) != numAsString.charAt(numLength - digit - 1))
				{
					isSymmetric = false;
				}
			}
			
			// Adding current number to an array if symmetric
			if (isSymmetric) {
				symmetricNums.add(numAsString);
			}
		}
		
		// Printing the result
		System.out.print("The symmetric numbers are: ");
		for (String num : symmetricNums) {
			System.out.print(num + " ");
		}
	}
}