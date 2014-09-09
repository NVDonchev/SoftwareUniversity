import java.util.Scanner;

public class _05_DecimalToHexadecimal {
	public static void main(String[] args) {
		// Getting user input
		System.out.print("Please enter a integer numbers: ");
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		
		// Converting to hexadecimal
		String hex = Integer.toHexString(num);
		
		// Printing the result
		System.out.printf("The hexadecimal value is: %s", hex.toUpperCase());
	}
}