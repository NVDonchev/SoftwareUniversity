import java.util.Scanner;

public class _06_SumTwoNumbers {
	public static void main(String[] args) {
		// Initializing a Scanner
		Scanner in = new Scanner(System.in);
		
		// Getting the integers from the console
		System.out.println("Enter two integers (on the same line with space):");
		int a = in.nextInt();
		int b = in.nextInt();
		
		// Printing the sum
		System.out.println("\nThe sum is:");
		System.out.println(a + b);
		
		// Closing the Scanner
		in.close();
	}
}