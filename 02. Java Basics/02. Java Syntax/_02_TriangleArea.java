import java.util.Scanner;

// Write a program that enters 3 points in the plane (as integer x and y coordinates),
// calculates and prints the area of the triangle composed by these 3 points.
// Round the result to a whole number. In case the three points do not form a triangle,
// print "0" as result.

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