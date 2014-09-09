import java.util.Scanner;

public class _08_CountOfBitPairs {
	public static void main(String[] args) {
		// Getting user input
		System.out.print("Please enter an integer number: ");
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		
		// Converting to binary representation
		String binaryNum = Integer.toBinaryString(num);
		
		// Counting the number of sequences of two equal bits
		int counter = 0;
		for (int bit = 0; bit < binaryNum.length() - 1; bit++) {
			if (binaryNum.charAt(bit) == binaryNum.charAt(bit + 1)) {
				counter++;
			}
		}
		
		// Printing the result
		System.out.printf("The number of sequences of two equal bits is: %d", counter);
	}
}