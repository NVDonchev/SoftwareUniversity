import java.util.Scanner;

public class _01_RectangleArea {
	public static void main(String[] args) {
		// Getting user input
		System.out.print("Please enter two positive integers: ");
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		int b = input.nextInt();
		
		// Printing the result
		System.out.printf("The rectangle area is: %d", a * b);
	}
}