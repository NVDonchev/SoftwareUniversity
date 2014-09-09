import java.util.Scanner;

public class _02_TriangleArea {
	public static void main(String[] args) {
		// Getting user input
		System.out.println("Please enter the coords for the points: ");
		Scanner input = new Scanner(System.in);
		int ax = input.nextInt();
		int ay = input.nextInt();
		int bx = input.nextInt();
		int by = input.nextInt();
		int cx = input.nextInt();
		int cy = input.nextInt();
		
		// Calculating the area
		int partA = ax * (by - cy);
		int partB = bx * (cy - ay);
		int partC = cx * (ay - by);
		int area = (partA + partB + partC) / 2;
		
		// Printing the result
		System.out.printf("The area is: %d", Math.abs(area));
	}
}