import java.util.Scanner;

public class _07_CountBitsOne {
	public static void main(String[] args) {
		// Getting user input
		System.out.print("Please enter an integer number: ");
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		
		// Counting ones
		System.out.printf("The number of ones is: %d", Integer.bitCount(num));
	}
}