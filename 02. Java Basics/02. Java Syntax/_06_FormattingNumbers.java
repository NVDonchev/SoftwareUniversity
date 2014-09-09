import java.util.Scanner;

public class _06_FormattingNumbers {
	public static void main(String[] args) {
		// Getting user input
		System.out.print("Please enter an integer and two floating-point numbers: ");
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		float b = input.nextFloat();
		float c = input.nextFloat();
		
		// Applying some formatting
		String aAsHex = Integer.toHexString(a).toUpperCase();
		String aAsBinary = String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0');
		
		// Printing with more formatting
		System.out.printf("|%-10s|%10s|%10.2f|%-10.3f|", aAsHex, aAsBinary, b, c);
	}
}